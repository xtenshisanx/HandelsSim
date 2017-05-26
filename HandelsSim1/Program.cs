using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandelsSim1
{
    class Program
    {
        public static List<Classes.Game.Product> Products;
        public static List<Classes.Game.Works> Works;
        public static Classes.Game.World GameWorld;
        public static readonly Random rng = new Random();
        static void Main(string[] args)
        {
            Products = new List<Classes.Game.Product>();
            Products.Add(new Classes.Game.Product("Brot", Classes.Game.Product.ProductCategory.Food));
            Products.Add(new Classes.Game.Product("Milch", Classes.Game.Product.ProductCategory.Food));
            Products.Add(new Classes.Game.Product("Kartoffeln", Classes.Game.Product.ProductCategory.Food));
            Products.Add(new Classes.Game.Product("Schuhe", Classes.Game.Product.ProductCategory.Luxury));
            Products.Add(new Classes.Game.Product("Holz", Classes.Game.Product.ProductCategory.RawMaterials));
            GameWorld = new Classes.Game.World();
            while (true)
            {
                Console.ReadKey();
                GameWorld.WeekEnd();
            }
        }
    }
}
