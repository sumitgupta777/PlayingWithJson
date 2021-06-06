using Newtonsoft.Json;
using PocTask1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.ViewModel
{
    public class ConfigureListVM
    {
        [JsonProperty("applications")]
        public IList<ConfigurationVM> applications { get; set; }
    }
}
