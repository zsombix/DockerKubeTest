using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Model;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly ColourContext context;

        public ValuesController(ColourContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Colour>> GetColourItems() 
        {
            return context.ColourItems;
        }
    }
}