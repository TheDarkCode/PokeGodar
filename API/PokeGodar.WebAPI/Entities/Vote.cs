using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.Azure.Documents.Spatial;
using Newtonsoft.Json;

namespace PokeGodar.WebAPI.Entities
{
    public class Vote : ItemBase
    {
        public Vote(string authorId = "anonymous") : base("report")
        {
            this.authorId = authorId;
            this.versionId = 1;
        }

        [Required]
        [JsonProperty("reportId")]
        public string ReportId { get; set; }
        [JsonProperty("value")]
        public bool Value { get; set; }
        [JsonProperty("comment")]
        public string Comment { get; set; }

    }
}
