using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace WebFrontEnd.Pages
{
    public class RedisCallModel : PageModel
    {
        public async Task OnGet()
        {
            using (var client = new HttpClient())
            {
                var response2 = await client.GetAsync("http://webapi/Cache/EnvironmentConnection");
                ViewData["RedisMessage"] = $"Redis env conn {await response2.Content.ReadAsStringAsync()} | ";

                var response3 = await client.GetAsync("http://webapi/Cache/Ping");
                ViewData["RedisMessage"] += $"{await response3.Content.ReadAsStringAsync()} | ";

                var data = JsonConvert.SerializeObject(new KeyValuePair<string, string>("myKey", "myValue"));
                await client.PostAsync("http://webapi/Cache/SetRedisData", new StringContent(data, Encoding.UTF8, "application/json"));

                var response4 = await client.GetAsync("http://webapi/Cache/GetRedisData?key=myKey");
                var valueOfKey = await response4.Content.ReadAsStringAsync();
                ViewData["RedisMessage"] += $"Value of myKey : {valueOfKey}";
            }
        }
    }
}