using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Entities
{
    public class Product
    {
        public static int Id { get; private set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }

        [StringLength(4)]
        public string ShortCode { get; set; }

        public string Description { get; set; }

        public List<Category> Categories { get; set; }
        public int SellingPrice { get; set; }
        public Product()
        {
            Id = Id + 1;
        }

    }
}
