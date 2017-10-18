using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    public class Weapon : Item
    {
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public Weapon(int iD, string name, string description, int minDmg, int maxDmg) : base(iD, name, description)
        {
            MinDamage = minDmg;
            MaxDamage = maxDmg;
        }

        

    }
}
