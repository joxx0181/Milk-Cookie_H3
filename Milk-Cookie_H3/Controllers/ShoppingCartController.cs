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
    public class ShoppingCartController : ControllerBase
    {
        // GET: api/<ShoppingCartController>
        [HttpGet]
        public IEnumerable <Product> Get(string name, double price)
        {
            // Create List!
            List<Product> products = new List<Product>();

            // Using if/else to check wheather the cart is empty or not!
            if(HttpContext.Session.GetString("cartsession") == null)
            {
                // Set session and add product to cart!
                products.Add(new Product(name, price));
                HttpContext.Session.SetObjectAsJson("cartsession", products);

            }
            else
            {
                // Get session and add product to cart!
                products = HttpContext.Session.GetObjectFromJson<List<Product>>("cartsession");
                products.Add(new Product(name, price));
                HttpContext.Session.SetObjectAsJson("cartsession", products);
            }

            return products;
        }
    }
}
