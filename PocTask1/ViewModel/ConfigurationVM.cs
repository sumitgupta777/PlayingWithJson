using PocTask1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PocTask1.ViewModel
{
    public class ConfigurationVM
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public Services Services { get; set; }
    }
}
