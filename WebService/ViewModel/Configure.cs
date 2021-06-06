
using PocTask1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.ViewModel
{
    public class Configure
    {
        public string Name { get; set; }
        
        public string DisplayName { get; set; }
        
        public ServicesVM Services { get; set; }
    }
}
