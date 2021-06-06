using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PocTask1.Models
{
    public class ServicesVM
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("endpoint")]
        public string Endpoint { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }
    }
}
