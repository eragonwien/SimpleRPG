using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    public class Potion : Item
    {
        public int HealingValue { get; set; }

        public Potion(int iD, string name, string description, int healingValue) : base(iD, name, description)
        {
            HealingValue = healingValue;
        }

        
    }
}
