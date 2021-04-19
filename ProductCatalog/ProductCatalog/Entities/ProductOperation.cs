using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Entities
{
    public class ProductOperation
    {
        public static List<Product> products = new List<Product>()
        {
            new Product()
            {
                Product_ID = Product.GenerateProductId(),
                ProductName = "Bat",
                ProductShortCode = "BAT",
                ProductDescription = "Wooden Bat",
                SellingPrice = 1000,
                ProductCategory = new List<Category>() {CategoryOperation.categories[1]},
                ProductManufacturer = "Adidas"
            },

            new Product()
            {
                Product_ID = Product.GenerateProductId(),
                ProductName = "Pen",
                ProductShortCode = "PEN",
                ProductDescription = "Pen with thin point",
                SellingPrice = 50,
                ProductCategory = new List<Category>() {CategoryOperation.categories[0]},
                ProductManufacturer = "Renoylds"
            },
        };

        
        public static void AddProduct(string ProductName, string shortCode, string desc, int price, string manufactureName)
        {
            CategoryOperation.categories.ForEach((i) =>
            {
                Console.WriteLine(i.CategoryID + i.CategoryName);
            });
            List<Category> productCategories = new List<Category>();
            string choice;
            do
            {
                Console.WriteLine("Select Category By Id For Adding a Product");
                int id = Convert.ToInt32(Console.ReadLine());
                var data = CategoryOperation.categories.Single((a) => a.CategoryID == id);
                if (data != null)
                    productCategories.Add(data);
                Console.WriteLine("Do you want to add more catagories, yes to continue otherwise no:");
                choice = Console.ReadLine();
            } while (choice == "yes");

            products.Add(new Product
            {
                Product_ID = Product.GenerateProductId(),
                ProductName = ProductName,
                ProductShortCode = shortCode,
                ProductDescription = desc,
                SellingPrice = price,
                ProductCategory = productCategories,
                ProductManufacturer = manufactureName

            });
           ListOfAllProducts();
        }

        public static void ListOfAllProducts()
        {
            Console.WriteLine("Product Id" + "\t" + "Product Name" + "\t" + "Product Short Code" + "\t" + "Product Description"+"\t"+"Product Price"+"\t"+"Categoty"+"\t"+"Manufacture\n");
            products.ForEach((i) =>
            {
                string s = "";
                i.ProductCategory.ForEach(c => {
                    s += c.CategoryName + ", ";
                });
                //Console.WriteLine($"{i.Product_ID} \t\t {i.product_Name}\t\t{i.ProductShortCode}\t\t{i.ProductDescription}\t\t{i.Selling_Price}\t\t{s}\t\t{i.Manufacturer}");
                Console.WriteLine($" {i.Product_ID} \t\t{i.ProductName}\t\t {i.ProductShortCode}\t\t\t  {i.ProductDescription}\t\t\t {i.SellingPrice}\t\t{s}\t\t {i.ProductManufacturer}");
            });
        }

        public static void DeleteProduct()
        {
            ListOfAllProducts();
            Console.WriteLine("a. Delete By ID");
            Console.WriteLine("b. Delete By Short Code");
            char ch2 = Convert.ToChar(Console.ReadLine());
            switch (ch2)
            {
                case 'a':
                    Console.WriteLine("Enter Id Number to delete");
                    int a = Convert.ToInt32(Console.ReadLine());
                    DeleteById(a);
                    break;
                case 'b':
                    Console.WriteLine("Enter Short Code of Category to Delete");
                    var sc = Console.ReadLine();
                    DeleteByShortCode(sc);
                    break;
            }
        }

        public static void DeleteById(int id)
        {
            bool flag = false;
            products.ForEach((i) =>
            {
                if (i.Product_ID == id)
                {
                    products.Remove(i);
                    ListOfAllProducts();
                }
                else
                {
                    flag = true;
                }
            });
            if (flag)
            {
                Console.WriteLine("Id not Found");
            }
        }

        public static void DeleteByShortCode(string shortCode)
        {
            bool flag = false;
            products.ForEach((i) =>
            {
                if (i.ProductShortCode == shortCode)
                {
                    products.Remove(i);
                    ListOfAllProducts();
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

        public static void SearchProduct()
        {
            Console.WriteLine("a. Search By ID");
            Console.WriteLine("b. Search By Name");
            Console.WriteLine("c. Search By Short Code");
            Console.WriteLine("d. Search By Price");
            char ch3 = Convert.ToChar(Console.ReadLine());
            switch (ch3)
            {
                case 'a':
                    Console.WriteLine("Enter Id Number to Search");
                    int a = Convert.ToInt32(Console.ReadLine());
                    SearchByID(a);
                    break;
                case 'b':
                    Console.WriteLine("Enter Neme of Product to Search");
                    var name = Console.ReadLine();
                    SearchByName(name);
                    break;
                case 'c':
                    Console.WriteLine("Enter Short Code of Product to Search");
                    var sc = Console.ReadLine();
                    SearchByShortCode(sc);
                    break;
                case 'd':
                    Console.WriteLine("Enter Price of Product to Search");
                    SearchByPrice();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }

        public static void SearchByID(int Id)
        {
            var data = products.FindAll((i) => i.Product_ID == Id);
            if (data.Count > 0)
            {
                data.ForEach((i) =>
                {
                    Console.WriteLine($"{i.Product_ID} \t\t {i.ProductName}\t\t{i.ProductShortCode}\t\t{i.ProductDescription}\t\t{i.SellingPrice}");
                });
            }
            else
            {
                Console.WriteLine("Id Not Found");
            }
        }

        public static void SearchByName(string name)
        {
            var data = products.FindAll((i) => i.ProductName == name);
            if (data.Count > 0)
            {
                data.ForEach((i) =>
                {
                    Console.WriteLine($"{i.Product_ID} \t\t {i.ProductName}\t\t{i.ProductShortCode}\t\t{i.ProductDescription}\t\t{i.SellingPrice}");
                });
            }
            else
            {
                Console.WriteLine("Name Not Found");
            }
        }
        public static void SearchByShortCode(string shortCode)
        {
            var data = products.FindAll((i) => i.ProductShortCode == shortCode);
            if (data.Count > 0)
            {
                data.ForEach((i) =>
                {
                    Console.WriteLine($"{i.Product_ID} \t\t {i.ProductName}\t\t{i.ProductShortCode}\t\t{i.ProductDescription}\t\t{i.SellingPrice}");
                });
            }
            else
            {
                Console.WriteLine("Short Code Not Found");
            }
        }

        public static void SearchByPrice()
        {
            Console.WriteLine("a. Search By Equal Price");
            Console.WriteLine("b. Search By Greater Price");
            Console.WriteLine("c. Search By Lesser Price");
            char ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("Enter Price for Equal Search");
                    int price = Convert.ToInt32(Console.ReadLine());
                    EqualPrice(price);
                    break;
                case 'b':
                    Console.WriteLine("Enter Price for Greater Search");
                    int greaterPrice = Convert.ToInt32(Console.ReadLine());
                    GraterPrice(greaterPrice);
                    break;
                case 'c':
                    Console.WriteLine("Enter Price for lesser Search");
                    int lesserPricerice = Convert.ToInt32(Console.ReadLine());
                    LesserPrice(lesserPricerice);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;

            }
        }

        public static void EqualPrice(int price)
        {
            var data = products.FindAll((i) => i.SellingPrice == price);
            if (data.Count > 0)
            {
                data.ForEach((i) =>
                {
                    Console.WriteLine($"{i.Product_ID} \t\t {i.ProductName}\t\t{i.ProductShortCode}\t\t{i.ProductDescription}\t\t{i.SellingPrice}");

                });
            }
            else
            {
                Console.WriteLine("Price not Found");
            }

        }
        public static void GraterPrice(int price)
        {
            var data = products.FindAll((i) => i.SellingPrice > price);
            if (data.Count > 0)
            {
                data.ForEach((i) =>
                {
                    Console.WriteLine($"{i.Product_ID} \t\t {i.ProductName}\t\t{i.ProductShortCode}\t\t{i.ProductDescription}\t\t{i.SellingPrice}");

                });
            }
            else
            {
                Console.WriteLine("Price not Found");
            }

        }
        public static void LesserPrice(int price)
        {
            var data = products.FindAll((i) => i.SellingPrice < price);
            if (data.Count > 0)
            {
                data.ForEach((i) =>
                {
                    Console.WriteLine($"{i.Product_ID} \t\t {i.ProductName}\t\t{i.ProductShortCode}\t\t{i.ProductDescription}\t\t{i.SellingPrice}");

                });
            }
            else
            {
                Console.WriteLine("Price not Found");
            }

        }
    }
}
