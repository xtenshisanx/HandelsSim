using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandelsSim1.Classes.Game
{
    public class Player : Gameobject
    {
        String Name;
        Int32 Money;
        List<Storage> Storages;

        public Player(String name)
        {
            Name = name;
            Id = World.Objectmanager.Count;
            Money = 5000;
            Storages = new List<Storage>();
        }

        public override void Simulate()
        {

        }
    }
}
