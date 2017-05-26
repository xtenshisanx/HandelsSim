using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HandelsSim1.Classes.Game
{
    public abstract class Gameobject
    {
        public Int32 Id;

        public abstract void Simulate();

        public enum ObjectType
        {
            NPC,
            Player,
            Town
        }
    }
}
