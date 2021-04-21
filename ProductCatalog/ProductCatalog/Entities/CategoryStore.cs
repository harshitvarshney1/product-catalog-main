using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Entities
{
    public class CategoryStore
    {
        public static List<Category> categories = new List<Category>()
        {
            new Category()
            {
              CategoryID = Category.GenerateCategoryId(),
              CategoryName="Stationary",
              CategoryShortCode="Stry",
              CategoryDescription="Stationary goods"
            },
            new Category
            {
                CategoryID = Category.GenerateCategoryId(),
                CategoryName="Sports",
                CategoryShortCode="Sprt",
                CategoryDescription="Sports goods"
            },
            new Category
            {
                CategoryID = Category.GenerateCategoryId(),
                CategoryName="Food",
                CategoryShortCode="FOOD",
                CategoryDescription="Food"
            }
        };
    }
}
