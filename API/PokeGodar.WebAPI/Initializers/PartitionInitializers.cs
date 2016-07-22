using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Partitioning;
using PokeGodar.WebAPI.Models;
using PokeGodar.WebAPI.Helpers;
using PokeGodar.WebAPI.PartitionResolvers;

namespace PokeGodar.WebAPI.Initializers
{
    /// <summary>
    /// Partition Initializers contains a collection of methods to initialize different partition resolvers
    /// to use such things as hash partitioning, lookup partitioning, and range partitioning.
    /// </summary>
    public class PartitionInitializers
    {
        /// <summary>
        /// The defaultOfferType is set in the config file, ie: S1, S2, S3. Will be used if no DocumentCollectionSpec is included for ManagedHashResolver.
        /// </summary>
        public static string defaultOfferType = AppSettingsConfig.DefaultOfferType;

        /// <summary>
        /// Initialize a HashPartitionResolver.
        /// </summary>
        /// <param name="partitionKeyPropertyName">The property name to be used as the partition Key.</param>
        /// <param name="client">The DocumentDB client instance to use.</param>
        /// <param name="database">The database to run the samples on.</param>
        /// <param name="collectionNames">The names of collections used.</param>
        /// <returns>The created HashPartitionResolver.</returns>
        public static async Task<HashPartitionResolver> InitializeHashResolver(string partitionKeyPropertyName, DocumentClient client, Database database, string[] collectionNames)
        {
            // Set local to input.
            string[] CollectionNames = collectionNames;
            int numCollectionNames = CollectionNames.Length;

            // Create array of DocumentCollections.
            DocumentCollection[] collections = new DocumentCollection[numCollectionNames];

            // Create string array of Self Links to Collections.
            string[] selfLinks = new string[numCollectionNames];

            //Create some collections to partition data.
            for (int i = 0; i < numCollectionNames; i++)
            {
                collections[i] = await DocumentClientHelper.GetCollectionAsync(client, database, CollectionNames[i]);
                selfLinks[i] = collections[i].SelfLink;
            }

            // Join Self Link Array into a comma separated string.
            string selfLinkString = String.Join(", ", selfLinks);

            //Initialize a partition resolver that users hashing, and register with DocumentClient. 
            //Uses User Id for PartitionKeyPropertyName, could also be TenantId, or any other variable.
            HashPartitionResolver hashResolver = new HashPartitionResolver(partitionKeyPropertyName, new[] { selfLinkString });
            client.PartitionResolvers[database.SelfLink] = hashResolver;

            return hashResolver;
        }

        /// <summary>
        /// Initialize a HashPartitionResolver that uses a custom function to extract the partition key.
        /// </summary>
        /// <param name="partitionKeyExtractor">The partition key extractor function.</param>
        /// <param name="client">The DocumentDB client instance to use.</param>
        /// <param name="database">The database to run the samples on.</param>
        /// <param name="collectionNames">The names of collections used.</param>
        /// <returns>The created HashPartitionResolver.</returns>
        public static async Task<HashPartitionResolver> InitializeCustomHashResolver(Func<object, string> partitionKeyExtractor, DocumentClient client, Database database, string[] collectionNames)
        {
            // Set local to input.
            string[] CollectionNames = collectionNames;
            int numCollectionNames = CollectionNames.Length;

            // Create array of DocumentCollections.
            DocumentCollection[] collections = new DocumentCollection[numCollectionNames];

            // Create string array of Self Links to Collections.
            string[] selfLinks = new string[numCollectionNames];

            //Create some collections to partition data.
            for (int i = 0; i < numCollectionNames; i++)
            {
                collections[i] = await DocumentClientHelper.GetCollectionAsync(client, database, CollectionNames[i]);
                selfLinks[i] = collections[i].SelfLink;
            }

            // Join Self Link Array into a comma separated string.
            string selfLinkString = String.Join(", ", selfLinks);

            var hashResolver = new HashPartitionResolver(
                partitionKeyExtractor,
                new[] { selfLinkString });

            client.PartitionResolvers[database.SelfLink] = hashResolver;
            return hashResolver;
        }

        /// <summary>
        /// Initialize a "managed" HashPartitionResolver that also takes care of creating collections, and cloning collection properties like
        /// stored procedures, offer type and indexing policy.
        /// </summary>
        /// <param name="partitionKeyExtractor">The partition key extractor function. (Ex: "u => ((UserProfile)u).UserId")</param>
        /// <param name="client">The DocumentDB client instance to use.</param>
        /// <param name="database">The database to run the samples on.</param>
        /// <param name="numCollections">The number of collections to be used.</param>
        /// <param name="collectionSpec">The DocumentCollectionSpec to be used for each collection created. If null returns Spec with defaultOfferType as set in config.</param>
        /// <returns>The created HashPartitionResolver.</returns>
        public static ManagedHashPartitionResolver InitializeManagedHashResolver(Func<object, string> partitionKeyExtractor, DocumentClient client, Database database, int numCollections, DocumentCollectionSpec collectionSpec)
        {
            // If no collectionSpec used, use a default spec with the offerType (ie: S1, S2, S3) that is specified in config.
            if (collectionSpec == null)
            {
                var hashResolver = new ManagedHashPartitionResolver(partitionKeyExtractor, client, database, numCollections, null, new DocumentCollectionSpec { OfferType = defaultOfferType });
                client.PartitionResolvers[database.SelfLink] = hashResolver;
                return hashResolver;
            }
            // If there is a collectionSpec passed as a parameter, use that instead of default.
            else
            {
                var hashResolver = new ManagedHashPartitionResolver(partitionKeyExtractor, client, database, numCollections, null, collectionSpec);
                client.PartitionResolvers[database.SelfLink] = hashResolver;
                return hashResolver;
            }
        }
    }
}
