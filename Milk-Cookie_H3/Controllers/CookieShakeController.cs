using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milk_Cookie_H3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CookieShakeController : ControllerBase
    {
        // GET: api/<CookieShakeController>
        [HttpGet]
        public string Get(string favoriteMilkshake)
        {
            DateTime now = DateTime.Now;

            // Create cookie object!
            CookieOptions cookie1 = new()
            {
                // Set the cookie expiration date!
                Expires = now.AddMinutes(5)
            };

            // Add the cookie.
            Response.Cookies.Append("favoriteMilkshake", favoriteMilkshake, cookie1);
            return favoriteMilkshake;
        }

        // GET: <api/SetCookie>
        [HttpGet]
        [Route("[action]")]
        public string GetFromCookie1()
        {
            // get the cookie data!
            return Request.Cookies["favoriteMilkshake"];
        }
    }
}
