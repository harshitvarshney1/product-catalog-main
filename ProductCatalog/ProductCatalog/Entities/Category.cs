using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Entities
{   
    public class Category
    {

        public static int Id = 1;
        public int ID { get; set; }
        public static int GenerateCategoryId()
        {
            return Id++;
        }
        [Required()]
        public string Name { get; set; } = " ";
        [StringLength(4)]
        public string ShortCode { get; set;}
        public string Description { get; set; }

    }
}
