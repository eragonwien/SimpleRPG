using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    public class LivingCreature
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public int BaseDamage { get; set; }
        

        public LivingCreature(int iD, string name, int maxHP, int currentHP, int baseDamage)
        {
            ID = iD;
            Name = name;
            MaxHP = maxHP;
            CurrentHP = currentHP;
            BaseDamage = baseDamage;
        }

        public LivingCreature()
        {

        }
    }


}
