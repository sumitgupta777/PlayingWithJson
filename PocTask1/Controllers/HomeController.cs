using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PocTask1.Models;
using PocTask1.ViewModel;
using Project_Health.Helper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace PocTask1.Controllers
{
    public class HomeController : Controller
    {

        ApiHelper _api = new ApiHelper();

        // Application starts from the below action method
        public async Task<IActionResult> GetJsonData()
        {
            ConfigureList app = new ConfigureList();

            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/Test/GetJsonData");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                app = JsonConvert.DeserializeObject<ConfigureList>(results);
            }
            return View(app);
      
        }


        // GET create 
        [HttpGet]
        public IActionResult AddJsonData()
        {
            return View();
        }

        // POST create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddJsonData(Configuration obj)
        {
            HttpClient client = _api.Initial();

            var postTask = client.PostAsJsonAsync<Configuration>("api/Test/AddJson", obj);
            postTask.Wait();

            var result = postTask.Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("GetJsonData");
            }
            

            return View(obj);
        }

        // GET - Edit
        public async Task<IActionResult> EditJsonEntry()
        {
            ConfigureList app = new ConfigureList();

            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/Test/GetJsonData");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                app = JsonConvert.DeserializeObject<ConfigureList>(results);
            }

            return View(app);
        }

        //// POST - edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditJsonEntry(ConfigureList obj)
        {
            var jsn = JsonConvert.SerializeObject(obj);
            HttpClient client = _api.Initial();

            //HTTP Post
            HttpResponseMessage response = await client.PutAsJsonAsync(
                 $"api/Test/UpdateJsonData", obj);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("GetJsonData");
            }

            return View(obj);
        }








        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
