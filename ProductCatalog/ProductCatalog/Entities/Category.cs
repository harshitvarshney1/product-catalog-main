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
        // public static int Id { get; set; }
        public  static int Id { get; set; }
        public string Name { get; set; }
        [StringLength(4)]
        public string ShortCode { get; set;}
        public string Description { get; set; }

        public static List<Category> printcategory = new List<Category>();
        public Category()
        {
            Id = Id + 1;
        }

        public void addCategory()
        {
            Console.WriteLine("Enter Name of Category");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Short Code:  Max 4 charachters");
            ShortCode = Console.ReadLine();

            Console.WriteLine("Enter Description for Category");
            Description = Console.ReadLine();

        }

        public static void showCategory()
        {
            foreach(Category i in printcategory)
            {
                Console.WriteLine(i);
            }
        }
    }
}
