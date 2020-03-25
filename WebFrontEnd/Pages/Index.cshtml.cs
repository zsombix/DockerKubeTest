using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace WebFrontEnd.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGet()
        {
            ViewData["Message"] = "Hello from the first Multi Container app \n";
            //using (var client = new HttpClient())
            //{
            //    var request = new HttpRequestMessage();
            //    request.RequestUri = new Uri("http://webapi/WeatherForecast");
            //    var response = await client.SendAsync(request);
                
            //    ViewData["ApiMessage"] += " and " + Environment.NewLine + await response.Content.ReadAsStringAsync();

            //    var response2 = await client.GetAsync("http://webapi/Cache/EnvironmentConnection");
            //    ViewData["RedisMessage"] = $"Redis env conn {await response2.Content.ReadAsStringAsync()} \n";

            //    var response3 = await client.GetAsync("http://webapi/Cache/Ping");
            //    ViewData["RedisMessage"] += $"{await response3.Content.ReadAsStringAsync()} \n";

            //    var data = JsonConvert.SerializeObject(new KeyValuePair<string, string>("myKey", "myValue"));
            //    await client.PostAsync("http://webapi/Cache/SetRedisData", new StringContent(data, Encoding.UTF8, "application/json"));

            //    var response4 = await client.GetAsync("http://webapi/Cache/GetRedisData?key=myKey");
            //    var valueOfKey = await response4.Content.ReadAsStringAsync();
            //    ViewData["RedisMessage"] += $"Value of myKey : {valueOfKey} \n";


            //}


        }
    }
}
