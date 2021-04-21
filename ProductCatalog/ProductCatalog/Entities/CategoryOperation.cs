using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Entities
{
    public class CategoryOperation : CategoryStore
    {

       public static void AddCategory(string categoryName, string shortCode, string description)
        {
            categories.Add(new Category
            {
                CategoryID = Category.GenerateCategoryId(),
                CategoryName = categoryName,
                CategoryShortCode = shortCode,
                CategoryDescription = description
            }) ;
            ListOfAllCategories();
        }

        public static void ListOfAllCategories()
        {
            Console.WriteLine("Category Id" + "\t" + "Category Name" + "\t" + "Category Short Code" + "\t" + "Category Description\n");
            categories.ForEach((i) =>
            {
                Console.WriteLine($"{i.CategoryID} \t\t {i.CategoryName}\t\t{i.CategoryShortCode}\t\t{i.CategoryDescription}");
            });
        }
       
        public static void deleteCategory()
        {
            Console.WriteLine("a. Delete By ID");
            Console.WriteLine("b. Delete By Short Code");
            string choicefordelete = Console.ReadLine();
            UserOperations.deleteCategoryMenu(choicefordelete);
        }

        public static void deleteById(int id)
        {
            categories.RemoveAt(id-1);
        }

        public static void deleteByShortCode(string shortcode)
        {
            bool flag = false;
            categories.ForEach((i) =>
            {
                if (i.CategoryShortCode == shortcode)
                {
                    categories.Remove(i);
                    ListOfAllCategories();
                }
                else
                {
                    flag = true;
                }
            });
            if (flag)
            {
                Console.WriteLine("Short Code not Found");
            }
        }
        public static void searchCategory()
        {
            Console.WriteLine("a. Search By ID");
            Console.WriteLine("b. Search By Name");
            Console.WriteLine("c. Search By Short Code");
            string choiceForSearch = Console.ReadLine();
            UserOperations.categorySearchMenu(choiceForSearch);
        }

        public static void searchById(int id)
        {
            var data = categories.FindAll((i) => i.CategoryID == id);
            if (data.Count > 0)
            {
                data.ForEach((i) =>
                {
                    Console.WriteLine($"{i.CategoryID} \t\t {i.CategoryName}\t\t{i.CategoryShortCode}\t\t{i.CategoryDescription}");
                });
            }
            else
            {
                Console.WriteLine("Id Not Found");
            }
        }

        public static void searchByName(string name)
        {
            var data = categories.FindAll((i) => i.CategoryName == name);
            if (data.Count > 0)
            {
                data.ForEach((i) =>
                {
                    Console.WriteLine($"{i.CategoryID} \t\t {i.CategoryName}\t\t{i.CategoryShortCode}\t\t{i.CategoryDescription}");
                });
            }
            else
            {
                Console.WriteLine("Name Not Found");
            }
        }

        public static void searchByShortCode(string shortCode)
        {
            var data = categories.FindAll((i) => i.CategoryShortCode == shortCode);
            if (data.Count > 0)
            {
                data.ForEach((i) =>
                {
                    Console.WriteLine($"{i.CategoryID} \t\t {i.CategoryName}\t\t{i.CategoryShortCode}\t\t{i.CategoryDescription}");
                });
            }
            else
            {
                Console.WriteLine("Short Code Not Found");
            }
        }
    }
}

