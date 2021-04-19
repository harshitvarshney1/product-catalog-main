using ProductCatalog.Entities;
using System;

namespace ProductCatalog
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product--Catalog!!");
           
            while (true)
            {
                Console.WriteLine("Enter Your Choice");
                Console.WriteLine(" 1- Category\n 2- Product\n 3-Exit the App!");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //Console.WriteLine("Category");
                        Console.WriteLine("Enter Choice for Category");
                        Console.WriteLine("\ta- Enter a Category");

                        Console.WriteLine("\tb- List all Categories");
                        Console.WriteLine("\tc- Delete a Category (Enter Short Code or ID to delete)");
                        Console.WriteLine("\td- Search a Category (By Id, Name, Short Code)");
                        string choiceforcategory = Console.ReadLine();
                        while (true)
                        {
                            switch (choiceforcategory.ToLower())
                            {
                                case "a":
                                    Category c = new Category();
                                    c.addCategory();
                                    Category.printcategory.Add(c);
                                   // For Autoincrement ID testing
                                    Console.WriteLine(Category.Id);
                                    break;
                                case "b":
                                    Category.showCategory();
                                    break;
                                case "c":
                                    break;
                                case "d":
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter Choice for Product");
                        Console.WriteLine("\ta- Enter a Product");

                        Console.WriteLine("\tb- List all Products");
                        Console.WriteLine("\tc- Delete a Product (Enter Short Code or ID to delete)");
                        Console.WriteLine("\td- Search a Product (By Id, Name, Short Code, Selling Price Greater than/Less Than/Equal To entered price)");
                        string choiceforproduct = Console.ReadLine();
                        switch(choiceforproduct.ToLower())
                        {
                            case "a":
                                Console.WriteLine("case a");

                                break;
                            case "b":
                                Console.WriteLine("case b");
                                break;
                            case "c":
                                break;
                            case "d":
                                break;
                            default:
                                break;
                        }
                       
                        break;
                    case 3:
                        Console.WriteLine("For Exit");
                        break;
                    default:
                        Console.WriteLine("Please Enter Right Choice");
                        break;
                }
            }
            
        }
    }
}
