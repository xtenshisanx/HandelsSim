using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandelsSim1.Classes.Game
{
    public class GameobjectManager
    {
        private List<Gameobject> objects;
        public Int32 Count { get { return objects.Count; } }
        public List<NPC> Npcs { get { return objects.OfType<NPC>().ToList(); } }
        public List<Town> Towns { get { return objects.OfType<Town>().ToList(); } }
        public List<Player> Players { get { return objects.OfType<Player>().ToList(); } }
        public List<Storage> Storages { get { return objects.OfType<Storage>().ToList(); } }
        public List<Works> Works { get { return objects.OfType<Works>().ToList(); } }
        public List<Gameobject> Objects { get { return objects; } }
        public GameobjectManager()
        {
            objects = new List<Gameobject>();
        }

        public void Add(Gameobject obj)
        {
            objects.Add(obj);
        }

        public void Remove(Gameobject obj)
        {
            Objects.Remove(obj);
        }
    }
}
