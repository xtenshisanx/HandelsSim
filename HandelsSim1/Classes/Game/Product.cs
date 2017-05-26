using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandelsSim1.Classes.Game
{
    public class Product
    {
        public String Name;
        public ProductCategory Category;

        public Product(String name, ProductCategory category)
        {
            Name = name;
            Category = category;
        }

        public enum ProductCategory
        {
            Food,
            RawMaterials,
            Luxury
        };
    }
}
