using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    public class Location
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public Item ItemRequiredToEnter { get; set; }
        public Quest QuestAvailable { get; set; }
        public Monster LocationMonster { get; set; }
        public Location LocationNord { get; set; }
        public Location LocationSouth { get; set; }
        public Location LocationWest { get; set; }
        public Location LocationOst { get; set; }

        public Location(int iD, string name, string description, Item itemRequiredToEnter = null, 
            Quest questAvailable = null, Monster locationMonster = null, Location locationNord = null, 
            Location locationSouth = null, Location locationWest = null, Location locationOst = null)
        {
            ID = iD;
            Name = name;
            Description = description;
            ItemRequiredToEnter = itemRequiredToEnter;
            QuestAvailable = questAvailable;
            LocationMonster = locationMonster;
            LocationNord = locationNord;
            LocationSouth = locationSouth;
            LocationWest = locationWest;
            LocationOst = locationOst;
        }

        
    }
}
