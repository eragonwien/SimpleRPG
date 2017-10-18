using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    public class Quest
    {
        public Quest(int iD, string name, string description, int rewardEXP, int rewardGold)
        {
            ID = iD;
            Name = name;
            Description = description;
            RewardEXP = rewardEXP;
            RewardGold = rewardGold;
            QuestCompletionItems = new List<QuestCompletionItem>();
        }

        public int ID { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public int RewardEXP { get; set; }
        public int RewardGold { get; set; }
        public List<QuestCompletionItem> QuestCompletionItems { get; set; }
    }
}
