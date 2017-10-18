using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsApp.Models
{
    public class Product
    {

        // zaken die we meesturen of ophalen via onze API (model)
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

    }
}
