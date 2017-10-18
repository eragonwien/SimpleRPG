using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    public class Player : LivingCreature
    {
        public Player(int iD, string name, int maxHP, int currentHP, int baseDamage, int gold, int exp, int level) : base(iD, name, maxHP, currentHP, baseDamage)
        {
            Gold = gold;
            Exp = exp;
            Level = level;
            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();
            MoveCounter = 0;
        }

        public Player()
        {
            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();
            MoveCounter = 0;
        }

        public int Gold { get; set; }
        public int Exp { get; set; }
        public int Level { get; set; }
        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }
        public Location CurrentLocation { get; set; }
        public int MoveCounter { get; set; }
    }
}
