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

        public static void AddProduct(string productName, string shortCode, string desc, int price, string manufacturerName)
        {

        }
    }
}
