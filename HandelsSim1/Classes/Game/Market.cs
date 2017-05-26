using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandelsSim1.Classes.Game
{
    public class Market
    {
        Int32 TownId;
        private Town Town => World.Objectmanager.Towns.Where(town => town.Id == TownId).FirstOrDefault();
        public Dictionary<Product, Int32> Products;
        List<Product> Demands;

        public Market(Int32 townId)
        {
            TownId = townId;
            Products = new Dictionary<Product, int>();
            foreach(Product prod in Program.Products)
            {
                var demandPerNpc = 0.00;
                if(prod.Category == Product.ProductCategory.Food)
                {
                    demandPerNpc = Statics.FoodDemandPerNpc;
                }
                if (prod.Category == Product.ProductCategory.RawMaterials)
                {
                    demandPerNpc = Statics.FoodDemandPerNpc;
                }
                if (prod.Category == Product.ProductCategory.Luxury)
                {
                    demandPerNpc = Statics.FoodDemandPerNpc;
                }
                var min = (Int32)Math.Round(Town.Population.Count * 4 * demandPerNpc / Program.Products.Count(product => product.Category == Product.ProductCategory.Food));
                var max = (Int32)Math.Round(Town.Population.Count * 6 * demandPerNpc / Program.Products.Count(product => product.Category == Product.ProductCategory.Food));
                Products.Add(prod, Program.rng.Next(min, max));
            }
            Demands = new List<Product>();
        }

        public void Simulate()
        {

        }
    }
}
