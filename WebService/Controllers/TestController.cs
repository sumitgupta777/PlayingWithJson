using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PocTask1.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using WebService.ViewModel;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public TestController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }


        [HttpGet]
        [Route("GetJsonData")]
        public string GetJsonData()
        {
            var webClient = new WebClient();
            var json = System.IO.File.ReadAllText(@"E:\project1\Extra\PocTask1\WebService\configuration.json");
            
            return json;

        }

        [HttpPost]
        [Route("AddJson")]
        public IActionResult AddJson([FromBody] ConfigurationVM obj)
        {
            // Deserializing the JSON data
            var json = System.IO.File.ReadAllText(@"E:\project1\Extra\PocTask1\WebService\configuration.json");
            ConfigureListVM data = JsonConvert.DeserializeObject<ConfigureListVM>(json);


            data.applications.Add(obj);
            // Serializing the json data
            var newJson = JsonConvert.SerializeObject(data);
            System.IO.File.WriteAllText(@"E:\project1\PocTask1\WebService\configuration.json", newJson);
            return Ok();
        }



        [HttpPut]
        [Route("UpdateJsonData")]
        public IActionResult UpdateJsonData(ConfigureListVM obj)
        {

            var newJson = JsonConvert.SerializeObject(obj);
            System.IO.File.WriteAllText(@"E:\project1\PocTask1\WebService\configuration.json", newJson);
            return Ok();
        }

    }
}
