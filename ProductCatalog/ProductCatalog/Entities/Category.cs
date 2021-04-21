using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Entities
{
    public class Category
    {

        public static int ID = 1;
        public int CategoryID { get; set; }
        public static int GenerateCategoryId()
        {
            return ID++;
        }
        public string CategoryName { get; set; }
        [StringLength(4)]
        public string CategoryShortCode { get; set;}
        public string CategoryDescription { get; set; }

    }
}
