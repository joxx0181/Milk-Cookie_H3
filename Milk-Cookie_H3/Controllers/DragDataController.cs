using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Milk_Cookie_H3.Controllers
{
    // Set the route!
    [Route("setp/dragd/[controller]")]
    [ApiController]
    public class DragDataController : ControllerBase
    {

        // GET: dragd/<DragDataController>
        [HttpGet]
        [Route("[action]")]
        public string GetFromCookie2()
        {
            // get the cookie data!
            return Request.Cookies["favoriteColor"];
        } 
    }
}
