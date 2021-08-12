using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Milk_Cookie_H3.Controllers
{
    // Set the route!
    [Route("setp/[controller]")]
    [ApiController]
    public class SetPathController : ControllerBase
    {
        // GET: setp/<SetPathController>
        [HttpGet]
        public string Get(string favoriteColor)
        {
            DateTime now = DateTime.Now;

            // Create cookie object!
            CookieOptions cookie2 = new()
            {

                // Set the cookie path!
                Path = "/setp",

                // Set the cookie expiration date!
                Expires = now.AddMinutes(5)
            };

            // Add the cookie.
            Response.Cookies.Append("favoriteColor", favoriteColor, cookie2);
            return favoriteColor;
        }
    }
}
