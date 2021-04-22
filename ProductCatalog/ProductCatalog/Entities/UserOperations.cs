using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Entities
{
    public class UserOperations
    {
        public static void showMenu()
        {
            while (true)
            {
                Console.WriteLine("Enter Your Choice");
                Console.WriteLine(" 1- Category\n 2- Product\n 3-Exit the App!");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Choice for Category");
                        Console.WriteLine("\ta- Enter a Category");

                        Console.WriteLine("\tb- List all Categories");
                        Console.WriteLine("\tc- Delete a Category (Enter Short Code or ID to delete)");
                        Console.WriteLine("\td- Search a Category (By Id, Name, Short Code)");
                        string choiceforcategory = Console.ReadLine();

                        switch (choiceforcategory.ToLower())
                        {
                            case "a":
                                Console.WriteLine("Enter Category Name");
                                var categoryName = Console.ReadLine();
                                Console.WriteLine("Enter Short Code");
                                var shortCode = Console.ReadLine();
                                Console.WriteLine("Enter Description");
                                var desc = Console.ReadLine();

                                CategoryOperation.AddCategory(categoryName, shortCode, desc);
                                break;
                            case "b":
                                CategoryOperation.ListOfAllCategories();
                                break;
                            case "c":
                                CategoryOperation.deleteCategory();
                                break;
                            case "d":
                                CategoryOperation.searchCategory();
                                break;
                            default:
                                break;
                        }

                        break;
                    case 2:
                        Console.WriteLine("Enter Choice for Product");
                        Console.WriteLine("\ta- Enter a Product");

                        Console.WriteLine("\tb- List all Products");
                        Console.WriteLine("\tc- Delete a Product (Enter Short Code or ID to delete)");
                        Console.WriteLine("\td- Search a Product (By Id, Name, Short Code, Selling Price Greater than/Less Than/Equal To entered price)");
                        string choiceforproduct = Console.ReadLine();
                        switch (choiceforproduct.ToLower())
                        {
                            case "a":
                                Console.WriteLine("Enter Product Name");
                                var productName = Console.ReadLine();
                                Console.WriteLine("Enter Short Code");
                                var shortCode = Console.ReadLine();
                                Console.WriteLine("Enter Description");
                                var desc = Console.ReadLine();
                                Console.WriteLine("Enter Price");
                                int price = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter Product Manufacturer Name");
                                var manufactureName = Console.ReadLine();
                                ProductOperation.AddProduct(productName, shortCode, desc, price, manufactureName);
                                break;
                            case "b":
                                ProductOperation.ListOfAllProducts();
                                break;
                            case "c":
                                ProductOperation.DeleteProduct();
                                break;
                            case "d":
                                ProductOperation.SearchProduct();
                                break;
                            default:
                                break;
                        }

                        break;
                    case 3:
                        Console.WriteLine("You have disconnected from program");
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Please Enter Right Choice");
                        break;
                }
            }

        }

        public static void categorySearchMenu(string choiceForSearch)
        {
            switch (choiceForSearch)
            {
                case "a":
                    Console.WriteLine("Enter Id Number to Search");
                    int id = Convert.ToInt32(Console.ReadLine());
                    CategoryOperation.searchById(id);
                    break;
                case "b":
                    Console.WriteLine("Enter Neme of Category to Search");
                    var name = Console.ReadLine();
                    CategoryOperation.searchByName(name);
                    break;
                case "c":
                    Console.WriteLine("Enter Short Code of Category to Search");
                    var sc = Console.ReadLine();
                    CategoryOperation.searchByShortCode(sc);
                    break;
            }
        }

        public static void deleteCategoryMenu(string choicefordelete)
        {
            switch (choicefordelete)
            {
                case "a":
                    Console.WriteLine("Enter Id Number to delete");
                    var i = Convert.ToInt32(Console.ReadLine());
                    CategoryOperation.deleteById(i);
                    break;
                case "b":
                    Console.WriteLine("Enter Short Code of category to Delete");
                    var sc = Console.ReadLine();
                    CategoryOperation.deleteByShortCode(sc);
                    break;
            }
        }

        public static void SearchProductMenu(char ch3)
        {
            switch (ch3)
            {
                case 'a':
                    Console.WriteLine("Enter Id Number to Search");
                    int a = Convert.ToInt32(Console.ReadLine());
                    ProductOperation.SearchByID(a);
                    break;
                case 'b':
                    Console.WriteLine("Enter Neme of Product to Search");
                    var name = Console.ReadLine();
                    ProductOperation.SearchByName(name);
                    break;
                case 'c':
                    Console.WriteLine("Enter Short Code of Product to Search");
                    var sc = Console.ReadLine();
                    ProductOperation.SearchByShortCode(sc);
                    break;
                case 'd':
                    Console.WriteLine("Enter Price of Product to Search");
                    ProductOperation.SearchByPrice();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }

        public static void DeleteProductMenu(char ch2)
        {
            switch (ch2)
            {
                case 'a':
                    Console.WriteLine("Enter Id Number to delete");
                    int a = Convert.ToInt32(Console.ReadLine());
                    ProductOperation.DeleteById(a);
                    break;
                case 'b':
                    Console.WriteLine("Enter Short Code of Category to Delete");
                    var sc = Console.ReadLine();
                    ProductOperation.DeleteByShortCode(sc);
                    break;
            }
        }

        public static void SearchByPriceMenu(char ch)
        {
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("Enter Price for Equal Search");
                    int price = Convert.ToInt32(Console.ReadLine());
                    ProductOperation.EqualPrice(price);
                    break;
                case 'b':
                    Console.WriteLine("Enter Price for Greater Search");
                    int greaterPrice = Convert.ToInt32(Console.ReadLine());
                    ProductOperation.GraterPrice(greaterPrice);
                    break;
                case 'c':
                    Console.WriteLine("Enter Price for lesser Search");
                    int lesserPricerice = Convert.ToInt32(Console.ReadLine());
                    ProductOperation.LesserPrice(lesserPricerice);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}