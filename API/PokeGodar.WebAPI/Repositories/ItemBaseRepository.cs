using PokeGodar.WebAPI.Entities;
using PokeGodar.WebAPI.Helpers;
using PokeGodar.WebAPI.Initializers;
using PokeGodar.WebAPI.PartitionResolvers;
using Microsoft.Azure.Documents.Partitioning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using PokeGodar.WebAPI.Repositories;

namespace PokeGodar.WebAPI.PartitionRepositories
{
    public class ItemBaseRepository : PartitioningRepositoryBase<ItemBase>, IItemBaseRepository
    {
        const int Hash = 0;
        const int ManagedHash = 1;

        public string[] collections = AppSettingsConfig.MainCollection.Split(',');

        public ItemBaseRepository(int resolverService) : base(AppSettingsConfig.Db)
        {
            getResolver(resolverService);
        }

        /// <summary>
        /// Initializes the partition resolver to be used with Item repository.
        /// </summary>
        /// <param name="resolverService"></param>
        public async void getResolver(int resolverService)
        {
            switch (resolverService)
            {
                case Hash:
                    HashPartitionResolver hashResolver = await PartitionInitializers.InitializeHashResolver("docType", Client, Database, collections);
                    break;
                case ManagedHash:
                    ManagedHashPartitionResolver managedHashResolver = PartitionInitializers.InitializeManagedHashResolver(i => ((ItemBase)i).docType, Client, Database, 3, null);
                    break;
                default:
                    goto case Hash;
            }
        }

        public IEnumerable<ItemBase> Find(Expression<Func<ItemBase, bool>> predicate)
        {
            return this.Find(null, predicate);
        }

        public override IEnumerable<ItemBase> Find(string docType, Expression<Func<ItemBase, bool>> predicate)
        {
            IEnumerable<string> collectionLinks = Client.PartitionResolvers[Database.SelfLink].ResolveForRead(docType);
            return collectionLinks.SelectMany(collectionLink => base.Find(collectionLink, predicate)).ToList();
        }

        public async Task<Document> Create(ItemBase item)
        {
            string collectionLink = Client.PartitionResolvers[Database.SelfLink].ResolveForCreate(item.docType);
            return await Create(collectionLink, item);
        }

    }
}
