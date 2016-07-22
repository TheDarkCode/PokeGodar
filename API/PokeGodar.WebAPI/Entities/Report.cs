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
    public class Report : ItemBase
    {
        public Report(string authorId = "anonymous") : base("report")
        {
            this.authorId = authorId;
            this.versionId = 1;
        }

        [Required]
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("level")]
        public string Level { get; set; }
        [JsonProperty("datetime")]
        public DateTime DateTime { get; set; }
        [JsonProperty("location")]
        public Point Location { get; set; }
        [JsonProperty("caught")]
        public bool Caught { get; set; }

    }
}
