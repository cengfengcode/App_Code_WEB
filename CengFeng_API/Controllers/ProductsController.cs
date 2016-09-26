using CengFeng_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using Newtonsoft.Json;
namespace CengFeng_API.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[] 
        { 
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 }, 
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M }, 
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M } 
        };

        public IEnumerable<Product> Get()
        {
            return products;
        }


        [System.Web.Http.HttpGet]
        [System.Web.Http.HttpPost]
        public Product Get(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            return product;
        }

    }
}
