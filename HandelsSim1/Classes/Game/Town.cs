using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandelsSim1.Classes.Game
{
    public class Town : Gameobject
    {
        public String Name;
        public List<NPC> Population => World.Objectmanager.Npcs.Where(npc => npc.TownId == Id).ToList();
        public List<Works> Works => World.Objectmanager.Works.Where(work => work.TownId == Id).ToList();
        public Market Market;
        
        public Town(String name)
        {
            Name = name;
            Id = World.Objectmanager.Count;
        }

        public override void Simulate()
        {
            foreach (Works work in Works)
            {
                work.Simulate();
            }
            foreach (NPC npc in Population)
            {
                npc.Simulate();
            }
            Market.Simulate();
        }
    }
}
