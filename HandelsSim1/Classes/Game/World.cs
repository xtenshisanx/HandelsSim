using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandelsSim1.Classes.Game
{
    class World
    {
        public static GameobjectManager Objectmanager;
        public World()
        {
            Objectmanager = new GameobjectManager();
            Objectmanager.Add(new Town("Eisenhaven"));
            Objectmanager.Add(new Town("Grafendorf"));
            Objectmanager.Add(new Player("Local Player"));
            Objectmanager.Add(Storage.CreateNormalStorage(Objectmanager.Towns[Program.rng.Next(0,Objectmanager.Towns.Count-1)],Objectmanager.Players[0]));
            var nextSex = NPC.NPCSex.Male;
            foreach (Town town in Objectmanager.Towns)
            {
                for (int i = 0; i != new Random().Next(150, 500); i++)
                {
                    var rngone = Program.rng.Next(0, Statics.Firstnames.Length);
                    var rngtwo = Program.rng.Next(0, Statics.Lastnames.Length);
                    var rngthree = Program.rng.Next(10, 60);
                    Objectmanager.Add(new NPC(Statics.Firstnames[rngone], Statics.Lastnames[rngtwo], rngthree, nextSex, town.Id));
                    if (nextSex == NPC.NPCSex.Male)
                    {
                        nextSex = NPC.NPCSex.Female;
                    }
                    else
                    {
                        nextSex = NPC.NPCSex.Male;
                    }

                }
            }
            foreach (Town town in Objectmanager.Towns)
            {
                town.Market = new Market(town.Id);
            }
            var t = Objectmanager.Towns[0];
            Objectmanager.Add(new Works(t.Id, t.Population[Program.rng.Next(0, t.Population.Count)].Id, Program.Products[0], 1, Works.WorkingType.Farm));
        }

        public void WeekStart()
        {

        }

        public void WeekEnd()
        {
            foreach(Town town in Objectmanager.Towns)
            {
                town.Simulate();
            }
        }

        public void Save()
        {

        }

        public void Load()
        {

        }
    }
}
