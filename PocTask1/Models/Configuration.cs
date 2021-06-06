using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PocTask1.Models
{
    public class Configuration
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public List<Services> Services { get; set; }
    }
}
