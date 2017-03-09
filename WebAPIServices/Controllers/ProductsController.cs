using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIServices.Models;
using System.Web.Http.Cors;

namespace WebAPIServices.Controllers
{
    [EnableCors(origins: "http://localhost:57217", headers: "*", methods: "*")]
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
       {
            new Product { Id = 1, Name = "Pasta", Category = "Groceries", Price = 2 },
            new Product { Id = 2, Name = "Lego", Category = "Toys", Price = 4.50M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 20.99M }
       };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
