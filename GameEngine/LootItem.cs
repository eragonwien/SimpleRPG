using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    public class LootItem
    {
        private int DropChancePercent { get; set; }
        private Boolean IsDefaultItem { get; set; }
        private Item Details { get; set; }
        private int Quantity { get; set; }

        public LootItem(Item details, int quantity, int dropChance, Boolean isDefaultItem)
        {
            Details = details;
            Quantity = quantity;
            DropChancePercent = dropChance;
            IsDefaultItem = isDefaultItem;
        }
        

    }
}
