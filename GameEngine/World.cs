using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    public static class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();

        // ITEM ID
        public const int ITEM_ID_SMALL_POTION = 1;
        public const int ITEM_ID_BIG_POTION = 2;
        public const int ITEM_ID_DAGGER = 3;
        public const int ITEM_ID_BRONZE_AXE = 4;
        public const int ITEM_ID_SILVER_SWORD = 5;
        public const int ITEM_ID_GREAT_SWORD = 6;
        public const int ITEM_ID_DOUBLE_DAGGER = 7;
        public const int ITEM_ID_STAFF = 8;
        public const int ITEM_ID_RAT_TAIL = 9;
        public const int ITEM_ID_WHEAT = 10;
        public const int ITEM_ID_DEMON_REST = 11;

        // MOSTER ID
        public const int MONSTER_ID_RAT= 1;
        public const int MONSTER_ID_THIEF = 2;
        public const int MONSTER_ID_ORC = 3;
        public const int MONSTER_ID_SKELETON = 4;
        public const int MONSTER_ID_WITCH = 5;
        public const int MONSTER_ID_GUARD_DOG = 6;
        public const int MONSTER_ID_DEMON = 7;

        // QUEST ID
        public const int QUEST_ID_CLEAR_ALCHEMIST_GARDEN = 1;
        public const int QUEST_ID_CLEAR_FARMER_FIELD = 2;
        public const int QUEST_ID_KILL_DEMON = 3;

        // LOCATION ID
        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_TOWN_SQUARE = 2;
        public const int LOCATION_ID_GUARD_POST = 3;
        public const int LOCATION_ID_ALCHEMIST_HUT = 4;
        public const int LOCATION_ID_ALCHEMIST_GARDEN = 5;
        public const int LOCATION_ID_FARM_HOUSE = 6;
        public const int LOCATION_ID_FARM_FIELD = 7;
        public const int LOCATION_ID_BRIDGE = 8;
        public const int LOCATION_ID_DEMON_LAIR = 9;

        public static Item GetItemByID(int id)
        {
            foreach (Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }
            return null;
        }

        public static Monster GetMonsterByID(int id)
        {
            foreach (Monster monster in Monsters)
            {
                if (monster.ID == id)
                {
                    return monster;
                }
            }
            return null;
        }

        public static Quest GetQuestByID(int id)
        {
            foreach (Quest quest in Quests)
            {
                if (quest.ID == id)
                {
                    return quest;
                }
            }
            return null;
        }

        public static Location GetLocationByID(int id)
        {
            foreach (Location location in Locations)
            {
                if (location.ID == id)
                {
                    return location;
                }
            }
            return null;
        }


        private static void PopulateItems()
        {
            Items.Add(new Potion(ITEM_ID_BIG_POTION, "Big Potion", "Heals 50 HP", 50));
            Items.Add(new Potion(ITEM_ID_SMALL_POTION, "Small Potion", "Heals 10 HP", 10));
            Items.Add(new Weapon(ITEM_ID_DAGGER, "Dagger", "Low Damage. Crit Chance. 1 - 50 Damage", 1, 50));
            Items.Add(new Weapon(ITEM_ID_BRONZE_AXE, "Bronze Sword", "Mediocre Damage. 10 - 15 Damage", 10, 15));
            Items.Add(new Weapon(ITEM_ID_SILVER_SWORD, "Silver Sword", "Good Damage. 15 - 20 Damage", 15, 20));
            Items.Add(new Weapon(ITEM_ID_GREAT_SWORD, "Great Sword", "High Damage. Can miss. 0 - 80 Damage", 0, 100));
            Items.Add(new Weapon(ITEM_ID_DOUBLE_DAGGER, "Dual Daggers", "High Speed. Low Damage. 1 - 50 Damage", 1, 50));
            Items.Add(new Weapon(ITEM_ID_STAFF, "Staff", "Consistent Damage. No crit chance. 15 Damage", 15, 15));
            Items.Add(new Item(ITEM_ID_RAT_TAIL, "Rat's Tail", "Required for first Quest."));
            Items.Add(new Item(ITEM_ID_WHEAT, "Wheat", "Required for second Quest"));
            Items.Add(new Item(ITEM_ID_DEMON_REST, "Demon's Rest", "Dropped after killing the Demon"));
        }

        private static void PolupateMonsters()
        {
            // Monster : rat, thief, orc, skeleton, witch, guard dog, demon

            Monster rat = new Monster(MONSTER_ID_RAT, "Rat", 2, 2, 1, 2, 1);
            rat.LootTable.Add(new LootItem(GetItemByID(ITEM_ID_RAT_TAIL), 1, 70, true));
            rat.LootTable.Add(new LootItem(GetItemByID(ITEM_ID_SMALL_POTION), 1, 50, false));

            Monster thief = new Monster(MONSTER_ID_THIEF, "Thief", 5, 5, 2, 5, 10);
            thief.LootTable.Add(new LootItem(GetItemByID(ITEM_ID_DAGGER), 1, 20, true));
            thief.LootTable.Add(new LootItem(GetItemByID(ITEM_ID_SMALL_POTION), 1, 50, false));
            thief.LootTable.Add(new LootItem(GetItemByID(ITEM_ID_DOUBLE_DAGGER), 1, 1, false));

            Monster orc = new Monster(MONSTER_ID_ORC, "Orc", 20, 20, 10, 20, 20);
            orc.LootTable.Add(new LootItem(GetItemByID(ITEM_ID_WHEAT), 1, 30, true));
            orc.LootTable.Add(new LootItem(GetItemByID(ITEM_ID_SMALL_POTION), 1, 50, false));
            orc.LootTable.Add(new LootItem(GetItemByID(ITEM_ID_BRONZE_AXE), 1, 20, true));

            Monster skeleton = new Monster(MONSTER_ID_SKELETON, "Skeleton Warrior", 20, 20, 20, 30, 30);
            skeleton.LootTable.Add(new LootItem(GetItemByID(ITEM_ID_DAGGER), 1, 30, false));
            skeleton.LootTable.Add(new LootItem(GetItemByID(ITEM_ID_STAFF), 1, 20, false));
            skeleton.LootTable.Add(new LootItem(GetItemByID(ITEM_ID_DOUBLE_DAGGER), 1, 10, false));

            Monster witch = new Monster(MONSTER_ID_WITCH, "Witch", 20, 20, 50, 50, 60);
            witch.LootTable.Add(new LootItem(GetItemByID(ITEM_ID_STAFF), 1, 30, true));
            witch.LootTable.Add(new LootItem(GetItemByID(ITEM_ID_SMALL_POTION), 1, 50, false));
            witch.LootTable.Add(new LootItem(GetItemByID(ITEM_ID_BIG_POTION), 1, 30, false));

            Monster guardDog = new Monster(MONSTER_ID_GUARD_DOG, "3-headed Guard Dog", 80, 80, 40, 80, 40);
            guardDog.LootTable.Add(new LootItem(GetItemByID(ITEM_ID_WHEAT), 1, 30, true));
            guardDog.LootTable.Add(new LootItem(GetItemByID(ITEM_ID_SILVER_SWORD), 1, 30, false));
            guardDog.LootTable.Add(new LootItem(GetItemByID(ITEM_ID_BIG_POTION), 1, 30, false));
            guardDog.LootTable.Add(new LootItem(GetItemByID(ITEM_ID_DOUBLE_DAGGER), 1, 30, false));

            Monster demon = new Monster(MONSTER_ID_DEMON, "Demon", 100, 100, 30, 100, 100);
            demon.LootTable.Add(new LootItem(GetItemByID(ITEM_ID_GREAT_SWORD), 1, 20, true));
            demon.LootTable.Add(new LootItem(GetItemByID(ITEM_ID_DEMON_REST), 1, 100, false));
            demon.LootTable.Add(new LootItem(GetItemByID(ITEM_ID_BIG_POTION), 1, 20, false));

            Monsters.Add(rat);
            Monsters.Add(thief);
            Monsters.Add(orc);
            Monsters.Add(witch);
            Monsters.Add(skeleton);
            Monsters.Add(guardDog);
            Monsters.Add(demon);
        }

        private static void PopulateQuests()
        {
            Quest clearAlchemistGardeQuest = new Quest(QUEST_ID_CLEAR_ALCHEMIST_GARDEN, "Clear Alchemist's Garden", "Kill rats in the garden and brings back three rat'S tails.", 20, 20);
            clearAlchemistGardeQuest.QuestCompletionItems.Add(new QuestCompletionItem(GetItemByID(ITEM_ID_RAT_TAIL), 3));
            
            Quest clearFarmFieldQuest = new Quest(QUEST_ID_CLEAR_FARMER_FIELD, "Witch's Wheat", "Kills witches on the field and brings back five wheats.", 40, 60);
            clearAlchemistGardeQuest.QuestCompletionItems.Add(new QuestCompletionItem(GetItemByID(ITEM_ID_WHEAT), 5));

            Quest killDemon = new Quest(QUEST_ID_KILL_DEMON, "Kill Demon", "Kills the Demon hidhing in Demon's Lair and brings back his ashes.", 80, 120);
            killDemon.QuestCompletionItems.Add(new QuestCompletionItem(GetItemByID(ITEM_ID_DEMON_REST), 1));

            Quests.Add(clearAlchemistGardeQuest);
            Quests.Add(clearFarmFieldQuest);
            Quests.Add(killDemon);
            
        }

        private static void PopulateLocations()
        {
            Location home = new Location(LOCATION_ID_HOME, "Home", "Home is where you live and starts the game");
            Location townsquare = new Location(LOCATION_ID_TOWN_SQUARE, "Town Square", "Town Square is where you choose your path");
            Location hut = new Location(LOCATION_ID_ALCHEMIST_HUT, "The Alchemist's Hut", "An Alchemist left his home for a long time");
            Location garden = new Location(LOCATION_ID_ALCHEMIST_GARDEN, "The Alchemist's Garden", "Witches can find a lot of ingredients for their potions here");
            Location farmhouse = new Location(LOCATION_ID_FARM_HOUSE, "The Farmhouse", "The house was destroyed by the orcs");
            Location farmfield = new Location(QUEST_ID_CLEAR_FARMER_FIELD, "Farmer's Field", "This field was a war cemetry");
            Location guardhouse = new Location(LOCATION_ID_GUARD_POST, "The Guard's Post", "The only entrance to the Demon's Lair");
            Location bridge = new Location(LOCATION_ID_BRIDGE, "The Bridge", "The Demon's Lair is on the other end of this bridge");
            Location demonlair = new Location(LOCATION_ID_DEMON_LAIR, "Demon's Lair", "The Evil awaits");

            home.LocationNord = townsquare;

            townsquare.LocationNord = hut;
            townsquare.LocationOst = guardhouse;
            townsquare.LocationSouth = home;
            townsquare.LocationWest = farmhouse;
            townsquare.QuestAvailable = GetQuestByID(QUEST_ID_KILL_DEMON);

            hut.LocationSouth = townsquare;
            hut.LocationNord = garden;
            hut.QuestAvailable = GetQuestByID(QUEST_ID_CLEAR_ALCHEMIST_GARDEN);
            hut.LocationMonster = GetMonsterByID(MONSTER_ID_RAT);

            garden.LocationSouth = hut;
            garden.LocationMonster = GetMonsterByID(MONSTER_ID_THIEF);

            farmhouse.LocationOst = townsquare;
            farmhouse.LocationWest = farmfield;
            farmhouse.QuestAvailable = GetQuestByID(QUEST_ID_CLEAR_FARMER_FIELD);
            farmhouse.LocationMonster = GetMonsterByID(MONSTER_ID_ORC);
            farmhouse.ItemRequiredToEnter = GetItemByID(ITEM_ID_RAT_TAIL);

            farmfield.LocationOst = farmhouse;
            farmfield.LocationMonster = GetMonsterByID(MONSTER_ID_WITCH);
            

            guardhouse.LocationWest = townsquare;
            guardhouse.LocationOst = bridge;
            guardhouse.LocationMonster = GetMonsterByID(MONSTER_ID_SKELETON);
            guardhouse.ItemRequiredToEnter = GetItemByID(ITEM_ID_WHEAT);

            bridge.LocationWest = guardhouse;
            bridge.LocationOst = demonlair;
            bridge.LocationMonster = GetMonsterByID(MONSTER_ID_GUARD_DOG);

            demonlair.LocationWest = bridge;
            demonlair.LocationMonster = GetMonsterByID(MONSTER_ID_DEMON);

            Locations.Add(home);
            Locations.Add(townsquare);
            Locations.Add(hut);
            Locations.Add(garden);
            Locations.Add(farmhouse);
            Locations.Add(farmfield);
            Locations.Add(guardhouse);
            Locations.Add(bridge);
            Locations.Add(demonlair);

        }

        static World()
        {
            PopulateItems();
            PolupateMonsters();
            PopulateQuests();
            PopulateLocations();
        }
    }
     
    
}
