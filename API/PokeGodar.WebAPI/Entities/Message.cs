using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.Azure.Documents.Spatial;
using Newtonsoft.Json;

namespace PokeGodar.WebAPI.Entities
{
    public class Message : ItemBase
    {
        public Message(string authorId = "anonymous") : base("report")
        {
            this.authorId = authorId;
            this.versionId = 1;
        }

        [Required]
        [JsonProperty("recipient")]
        public string Recipient { get; set; }
        [JsonProperty("public")]
        public bool Public { get; set; }
        [JsonProperty("body")]
        public string Body { get; set; }
        [JsonProperty("datetime")]
        public DateTime DateTime { get; set; }
        [JsonProperty("location")]
        public Point Location { get; set; }
        [JsonProperty("delivered")]
        public bool Delivered { get; set; }
        [JsonProperty("read")]
        public bool Read { get; set; }

    }
}
