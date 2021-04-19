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

        
   
        //public void addCategory()
        //{
        //    Console.WriteLine("Enter Name of Category");
        //    Name = Console.ReadLine();

        //    Console.WriteLine("Enter Short Code:  Max 4 charachters");
        //    ShortCode = Console.ReadLine();

        //    Console.WriteLine("Enter Description for Category");
        //    Description = Console.ReadLine();

        //}

        //public static void showCategory()
        //{
        //    foreach(Category i in printcategory)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
    }
}
