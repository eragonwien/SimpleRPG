using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    public class PlayerQuest
    {
        public PlayerQuest(Quest details)
        {
            Details = details;
            IsCompleted = false;
        }

        public PlayerQuest(Quest details, Location location)
        {
            Details = details;
            IsCompleted = false;
            Location = location;
        }

        public Quest Details { get; set; }
        public Boolean IsCompleted { get; set; }
        public Location Location { get; set; }

    }
}
