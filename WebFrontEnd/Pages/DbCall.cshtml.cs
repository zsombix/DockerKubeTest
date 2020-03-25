using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebFrontEnd.Pages
{
    public class DbCallModel : PageModel
    {
        public async Task OnGet()
        {
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage();
                request.RequestUri = new Uri("http://webapi/Values");
                var response = await client.SendAsync(request);

                ViewData["DbMessage"] = await response.Content.ReadAsStringAsync();
            }
        }
    }
}