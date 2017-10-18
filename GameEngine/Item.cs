using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    public class Item
    {
        public Item(int iD, string name, string description)
        {
            ID = iD;
            Name = name;
            Description = description;
        }

        public int ID { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
    }
}
