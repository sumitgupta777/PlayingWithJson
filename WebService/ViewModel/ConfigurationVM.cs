using Newtonsoft.Json;
using PocTask1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PocTask1.ViewModel
{
    public class ConfigurationVM
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("services")]
        public List<ServicesVM> Services { get; set; }
    }
}
