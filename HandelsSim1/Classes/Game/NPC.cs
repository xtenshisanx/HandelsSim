using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandelsSim1.Classes.Game
{
    public class NPC : Gameobject
    {
        private Int32 ChanceForDisease = 2;
        private Int32 ChanceForDeath = 1;
        private Int32 ChanceForBirth = 1;
        private Int32 MinimumAgeforDeath = 14;

        public String FirstName;
        public String LastName;
        public Int32 Age;
        public Int32 Partner;
        public Int32 TownId;
        public Int32 WorkId;
        public NPCSex Sex;
        public NPCRelationshipStatus RelationshipStatus;

        public NPC(String firstname, String lastname, Int32 age, NPCSex sex, Int32 townid)
        {
            Id = World.Objectmanager.Count;
            TownId = townid;
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Sex = sex;
        }

        public override void Simulate()
        {
            var Rng = Program.rng.Next(0, 100);
            if (Rng >= (100 - ChanceForDeath) && Age >= MinimumAgeforDeath)
            {
                Die();
            }
        }

        public void Die()
        {
            Console.WriteLine("Gamemaster: {0} {1} ({2}) Died", FirstName, LastName, Id);
            foreach(Works work in World.Objectmanager.Works)
            {
                if(work.OwnerId == Id)
                {
                    Console.WriteLine("Gamemaster: Work({0}) is without a Master", work.Id);
                }
            }
            World.Objectmanager.Remove(this);
        }

        public enum NPCRelationshipStatus
        {
            Single,
            Married
        }

        public enum NPCSex
        {
            Male,
            Female
        }

        public void AddWork(Int32 workId)
        {
            WorkId = workId;
        }
    }
}
