using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandelsSim1.Classes.Game
{
    public class Works : Gameobject
    {
        public Int32 Level;
        public List<NPC> Worker => World.Objectmanager.Npcs.Where(npc => npc.WorkId == Id).ToList();
        private Town Town => World.Objectmanager.Towns.Where(town => town.Id == TownId).FirstOrDefault();
        public Int32 TownId;
        public Int32 OwnerId;
        public Int32 AmountPerDay;
        public Product Produces;
        public WorkingType WorkType;

        public enum WorkingType
        {
            Farm,
            Fisher,
            Hunter,
            Forester,
            Worker
        }

        public Works(Int32 townId, Int32 ownerId, Product produces, Int32 amountPerDay, WorkingType workingType)
        {
            Level = 1;
            Id = World.Objectmanager.Count;
            World.Objectmanager.Npcs.Where(npc => npc.Id == ownerId).FirstOrDefault().WorkId = Id;
            TownId = townId;
            OwnerId = ownerId;
            Produces = produces;
            AmountPerDay = amountPerDay;
            WorkType = workingType;
        }

        public override void Simulate()
        {
            var rng = Program.rng.Next(0, 100);
            if (rng < 100 - Statics.ProblemChance)
            {
                var oldValue = Town.Market.Products.FirstOrDefault(prod => prod.Key.Equals(Produces)).Value;
                Town.Market.Products[Produces] += AmountPerDay;
                Console.WriteLine("Work({0}): Produced {1} Tonns of {2}", Id, AmountPerDay, Produces.Name);
            }
            else
            {
                Console.WriteLine("Work({0}): Had Problems with the Production, nothing was Produced", Id);
            }
        }
    }
}
