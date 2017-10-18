using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    public class Monster : LivingCreature
    {
        public Monster(int iD, string name, int maxHP, int currentHP, int baseDamage, int rewardexp, int rewardgold) : base(iD, name, maxHP, currentHP, baseDamage)
        {
            RewardEXP = rewardexp;
            RewardGold = rewardgold;
            LootTable = new List<LootItem>();
        }

        public Monster()
        {
            LootTable = new List<LootItem>();
        }

        public int RewardEXP { get; set; }
        public int RewardGold { get; set; }
        public List<LootItem> LootTable { get; set; }
    }


}
