using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Milk_Cookie_H3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milk_Cookie_H3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeleteController : ControllerBase
    {
        // DELETE api/<DeleteController>/5
        [HttpDelete]
        public IEnumerable<Product> Delete(string name)
        {
            // Create List!
            List<Product> products = new List<Product>();

            // Using if/else to check wheather the session exists or not!
            if (HttpContext.Session.GetString("cartsession") != null)
            {
                // remove product in cart!
                products = HttpContext.Session.GetObjectFromJson<List<Product>>("cartsession");
                products.RemoveAll(p => p.Name == name);

                HttpContext.Session.SetObjectAsJson("cartsession", products);
            }
            return products;
        }
    }
}

