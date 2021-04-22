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
              ID = Category.GenerateCategoryId(),
              Name="Stationary",
              ShortCode="Stry",
              Description="Stationary goods"
            },
            new Category
            {
                ID = Category.GenerateCategoryId(),
                Name="Sports",
                ShortCode="Sprt",
                Description="Sports goods"
            },
            new Category
            {
                ID = Category.GenerateCategoryId(),
                Name="Food",
                ShortCode="FOOD",
                Description="Food"
            }
        };
    }
}
