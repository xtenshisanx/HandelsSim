using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandelsSim1.Classes.Game
{
    public class Storage : Gameobject
    {
        Int32 TownId;
        Int32 PlayerId;
        Int32 Capacity;
        Int32 MaintenanceCosts;
        Int32 Level;
        List<Product> Products;

        public static Storage CreateNormalStorage(Town town, Player player)
        {
            Storage result = new Storage();
            result.Id = World.Objectmanager.Count;
            result.TownId = town.Id;
            result.PlayerId = player.Id;
            result.Capacity = 100;
            result.Level = 1;
            result.MaintenanceCosts = 20;
            result.Products = new List<Product>();
            return result;
        }

        public override void Simulate()
        {

        }
    }
}
