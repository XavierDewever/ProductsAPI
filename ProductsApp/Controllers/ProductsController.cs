using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using ProductsApp.Models; // meegeven dat we met deze specifieke models willen werken

namespace ProductsApp.Controllers
{
    [Produces("application/json")]
    
    public class ProductsController : Controller // erft over van controller klasse
    {
        private Product[] products = new Product[]
        {
            new Product {Id = 1, Name="Bananen", Category="Fruit", Price=1},
            new Product {Id = 2, Name="Teddybeer", Category="Speelgoed", Price=3.75M},
            new Product {Id = 3, Name="Harddisk", Category="Hardware", Price=16.99M}
        };

        [Route("api/Products")] // URL route 
        public IEnumerable<Product> GetAllProducts() // list van producten // web API controller
        {
            return products;
        }

        [Route("api/Products/{id}")] // URL route 
        public Product GetProduct(int id) // web API controller
        {
            var product = products.FirstOrDefault((p) => p.Id == id); // we zoeken binnen products, naar het eerste product met een overeenkomend id
            return product;
        }

    }


}
