using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PokeGodar.WebAPI.Entities
{
    public class ItemBase
    {
        private readonly string _docType;

        /// <summary>
        /// All root entities inherit this base class.
        /// </summary>
        /// <param name="docType">The name of the type of entity (lowercase).</param>
        public ItemBase(string docType)
        {
            this._docType = docType;
        }

        /// <summary>
        /// This is needed for querying in the RepositoryBase. Used by DocumentDB.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// This is needed for organizing documents created by anonymous or registered users.
        /// </summary>
        [JsonProperty(PropertyName = "authorId")]
        public string authorId { get; set; }

        /// <summary>
        /// This is needed for tracking documents that might be modified or updated.
        /// </summary>
        [JsonProperty(PropertyName = "versionId")]
        public int versionId { get; set; }

        /// <summary>
        /// This docType field will be used to organize the documents by "docType" in 
        /// DocumentDB in a single-collection scenario.  The docType is just the lowercase
        /// name of the derived class.
        /// </summary>
        [JsonProperty(PropertyName = "docType")]
        public string docType { get { return _docType; } }
    }
}
