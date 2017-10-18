using GameEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeRPGGame
{
    public partial class SimpleRPG : Form
    {
        private Player player;
        private Monster currentMonster;

        public SimpleRPG()
        {
            InitializeComponent();
            SetupLogWindows();
            CreateNewPlayer();
        }

        private void SetupLogWindows()
        {
            // Quest Log
            dgvQuestLog.RowHeadersVisible = false;
            dgvQuestLog.Columns.Add("Name", "Name");
            dgvQuestLog.Columns["Name"].Width = 150;
            dgvQuestLog.Columns.Add("Location", "Location");
            dgvQuestLog.Columns["Location"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvQuestLog.Columns["Location"].FillWeight = 15;
            dgvQuestLog.Columns.Add("Status", "Status");
            dgvQuestLog.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvQuestLog.Columns["Status"].FillWeight = 10;
            dgvQuestLog.Rows.Clear();

            // Inventory Log
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.Columns.Add("Q.", "Q.");
            dgvInventory.Columns["Q."].Width = 30;
            dgvInventory.Columns.Add("Name", "Name");
            dgvInventory.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvInventory.Columns["Name"].FillWeight = 70;
            dgvInventory.Columns.Add("Type", "Type");
            dgvInventory.Columns["Type"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvInventory.Columns["Type"].FillWeight = 30;
            dgvInventory.AutoResizeColumns();
            dgvInventory.Rows.Clear();
        }

        private void CreateNewPlayer()
        {
            /* 
             * Player 1 can have max. 100 HP
             * starts with 10 HP, base damage of 1, 10 gold at level 1
            */
            player = new Player();
            player.Name = "Eragonwien";
            player.Level = 1;
            player.CurrentHP = 10;
            player.MaxHP = 10;
            player.Gold = 10;
            player.BaseDamage = 1;
            player.ID = 1;
            player.Exp = 0;

            MoveTo(World.GetLocationByID(World.LOCATION_ID_HOME));
            player.Inventory.Add(new InventoryItem(World.GetItemByID(World.ITEM_ID_SMALL_POTION), 3));
            player.Inventory.Add(new InventoryItem(World.GetItemByID(World.ITEM_ID_DAGGER), 3));

            RefreshDirectionButtonsVisibility();
            EnableAction(false, false);
            DisplayCurrentPlayerStatus();
        }

        private void DisplayCurrentPlayerStatus()
        {
            // update stats
            lblGold.Text = player.Gold.ToString();
            lblEXP.Text = player.Exp.ToString();
            lblHP.Text = player.CurrentHP.ToString();
            lblLevel.Text = player.Level.ToString();
            lblMoveCounterValue.Text = player.MoveCounter.ToString();
            
            // starter log
            if (rtbLog.Text.Equals(""))
            {
                WriteLog("A new Hero is born.");
            }

            // update location log
            rtbLocation.Text = player.CurrentLocation.Name + "\n" + player.CurrentLocation.Description;

            // update quest log
            dgvQuestLog.Rows.Clear();

            foreach (PlayerQuest pquest in player.Quests)
            {
                String questStatus = (pquest.IsCompleted) ? "Completed" : "Incompleted";
                dgvQuestLog.Rows.Add(new[] { pquest.Details.Name, pquest.Location.Name, questStatus });
            }

            // update inventory
            dgvInventory.Rows.Clear();

            foreach (InventoryItem invItem in player.Inventory)
            {
                Item invItemDetail = invItem.Details;
                String itemType;
                if (invItemDetail is Potion)
                {
                    itemType = "Potion";
                }
                else if (invItemDetail is Weapon)
                {
                    itemType = "Weapon";
                }
                else
                {
                    itemType = "Unknown";
                }
                dgvInventory.Rows.Add(new[] { invItem.Quantity.ToString(), invItem.Details.Name, itemType });
            }

            // update weapon action combo box
            List<Weapon> weapons = new List<Weapon>();
            List<Potion> potions = new List<Potion>();

            foreach (InventoryItem invItem in player.Inventory)
            {
                if (invItem.Details is Weapon)
                {
                    weapons.Add((Weapon)invItem.Details);
                }
                else if (invItem.Details is Potion)
                {
                    potions.Add((Potion)invItem.Details);
                }
            }

            EnableAction((weapons.Count > 0), (potions.Count > 0));

            // update potion action combo box
            if (potions.Count > 0)
            {
                cboxPotion.DataSource = potions;
                cboxPotion.DisplayMember = "Name";
                cboxPotion.ValueMember = "ID";
            }

            if (weapons.Count > 0)
            {
                cboxWeapon.DataSource = weapons;
                cboxWeapon.DisplayMember = "Name";
                cboxWeapon.ValueMember = "ID";
            }
        }

        private void EnableAction(bool weaponAllowed, bool potionAllowed)
        {
            cboxWeapon.Enabled = weaponAllowed;
            cboxPotion.Enabled = potionAllowed;
            btnUseWeapon.Enabled = weaponAllowed;
            btnUsePotion.Enabled = potionAllowed;

            lblSelectAction.Enabled = (weaponAllowed || potionAllowed);
        }

        private void btnUseWeapon_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUsePotion_Click(object sender, EventArgs e)
        {

        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            //Confirm Player's Action command
            // If no monster found or monster is dead = walk away
            // else player fleed
            if ((currentMonster == null) || (currentMonster.CurrentHP <= 0))
            {
                WriteLog("You went to Nord.");
            }
            else
            {
                WriteLog("You fleed to Nord.");
            }
            
            MoveTo(player.CurrentLocation.LocationNord);
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            if ((currentMonster == null) || (currentMonster.CurrentHP <= 0))
            {
                WriteLog("You went to West.");
            }
            else
            {
                WriteLog("You fleed to West.");
            }
            MoveTo(player.CurrentLocation.LocationWest);
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            if ((currentMonster == null) || (currentMonster.CurrentHP <= 0))
            {
                WriteLog("You went to South.");
            }
            else
            {
                WriteLog("You fleed to South.");
            }
            MoveTo(player.CurrentLocation.LocationSouth);
        }

        private void btnOst_Click(object sender, EventArgs e)
        {
            if ((currentMonster == null) || (currentMonster.CurrentHP <= 0))
            {
                WriteLog("You went to Ost.");
            }
            else
            {
                WriteLog("You fleed to Ost.");
            }
            MoveTo(player.CurrentLocation.LocationOst);
        }

        private void MoveTo(Location location)
        {
            // Raise Move Counter
            player.MoveCounter++;
            // Check Item Requirement
            if (location.ItemRequiredToEnter != null)
            {
                Boolean playerHasRequiredItem = false;
                foreach (InventoryItem item in player.Inventory)
                {
                    if (item.Details.ID == location.ItemRequiredToEnter.ID)
                    {
                        playerHasRequiredItem = true;
                        break;
                    }
                }

                if (!playerHasRequiredItem)
                {
                    rtbLog.Text += "You can not enter. Reason: no " + location.ItemRequiredToEnter.Name + ".\n";
                    return;
                }
            }

            // Update player location
            player.CurrentLocation = location;
            RefreshDirectionButtonsVisibility();
            

            // Heals the player 20% of the max HP
            int healingValue = (int)(0.2 * player.MaxHP);
            int hpLoss = player.MaxHP - player.CurrentHP;
            healingValue = (healingValue > hpLoss) ? hpLoss : healingValue;
            player.CurrentHP += healingValue;
            if (healingValue > 0)
            {
                WriteLog("Entering " + location.Name + " heals " + healingValue + " HP.");
            }

            // Check if the location have a quest
            Quest locationQuest = location.QuestAvailable;
            PlayerQuest acceptedQuest = null;
            if (locationQuest != null)
            {
                // If yes, check if player accepted the quest
                Boolean questAccepted = false;
                
                foreach (PlayerQuest pquest in player.Quests)
                {
                    if (pquest.Details.ID == locationQuest.ID)
                    {
                        acceptedQuest = pquest;
                        questAccepted = true;
                        break;
                    }
                }

                if (questAccepted)
                {
                    // If yes, check for quest completion
                    if (!acceptedQuest.IsCompleted)
                    {
                        // If no, check for quest item in inventory
                        Boolean questCompleted = true;

                        foreach (QuestCompletionItem completionItem in acceptedQuest.Details.QuestCompletionItems)
                        {
                            Boolean playerHasRequiredItem = false;
                            foreach (InventoryItem invItem in player.Inventory)
                            {
                                if ((invItem.Details.ID == completionItem.Details.ID) && (invItem.Quantity == completionItem.Quantity))
                                {
                                    playerHasRequiredItem = true;
                                    break;
                                }
                            }
                            if (!playerHasRequiredItem)
                            {
                                questCompleted = false;
                                break;
                            }
                        }
                        if (questCompleted)
                        {
                            // If yes, complete quest
                            
                            // remove quest items
                            foreach (QuestCompletionItem completionItem in acceptedQuest.Details.QuestCompletionItems)
                            {
                                foreach (InventoryItem invItem in player.Inventory)
                                {
                                    if ((invItem.Details.ID == completionItem.Details.ID) && (invItem.Quantity == completionItem.Quantity))
                                    {
                                        player.Inventory.Remove(invItem);
                                        rtbLog.Text += invItem.Quantity + " " + invItem.Details.ID + " removed.\n";
                                        break;
                                    }
                                }
                            }
                            // give rewards
                            player.Gold += acceptedQuest.Details.RewardGold;
                            player.Exp += acceptedQuest.Details.RewardEXP;
                            rtbLog.Text += acceptedQuest.Details.RewardGold + " Gold and " + acceptedQuest.Details.RewardEXP + " EXP received\n";

                            // marks as completed
                            foreach (PlayerQuest playerQuest in player.Quests)
                            {
                                if (playerQuest.Details.ID == acceptedQuest.Details.ID)
                                {
                                    playerQuest.IsCompleted = true;
                                    // display result on log
                                    rtbLog.Text += "Quest " + acceptedQuest.Details.Name + " is completed\n";
                                }
                            }

                        }
                    }
                }
                else
                {
                    // If no, display and add the quest
                    player.Quests.Add(new PlayerQuest(locationQuest, location));
                    // display result on log
                    WriteLog("Quest " + locationQuest.Name + "  received");
                    rtbLog.Text += "To complete this quest, please return ";
                    foreach (QuestCompletionItem qItem in locationQuest.QuestCompletionItems)
                    {
                        rtbLog.Text += qItem.Quantity + " " + qItem.Details.Name;
                    }
                    rtbLog.Text += "\n";
                }
            }

            // Check if there is a monster in the current location
            currentMonster = location.LocationMonster;
            if (currentMonster != null)
            {
                // Spawn new monster except demon
                if (location.LocationMonster.ID != World.GetMonsterByID(World.MONSTER_ID_DEMON).ID)
                {
                    Monster standardMonster = World.GetMonsterByID(World.MONSTER_ID_DEMON);
                    currentMonster = new Monster(standardMonster.ID, standardMonster.Name, standardMonster.MaxHP, standardMonster.CurrentHP, standardMonster.BaseDamage, standardMonster.RewardEXP, standardMonster.RewardGold);
                    foreach (LootItem loot in standardMonster.LootTable)
                    {
                        currentMonster.LootTable.Add(loot);
                    }
                    WriteLog("A wild " + currentMonster.Name + " appears.");

                    WriteLog("Current Monster :" + currentMonster.CurrentHP + "HP");
                    WriteLog("World Monster :" + World.GetMonsterByID(location.LocationMonster.ID).CurrentHP + "HP");
                }

                // Show action selection
                EnableAction(true, true);
            }
            else
            {
                // Hide action selection
                EnableAction(false, false);
            }

            
            // Displays Status
            DisplayCurrentPlayerStatus();
        }

        private void RefreshDirectionButtonsVisibility()
        {
            btnNorth.Visible = (player.CurrentLocation.LocationNord != null);
            btnOst.Visible = (player.CurrentLocation.LocationOst != null);
            btnSouth.Visible = (player.CurrentLocation.LocationSouth != null);
            btnWest.Visible = (player.CurrentLocation.LocationWest != null);
        }

        private void rtbLog_OnTextChanged(object sender, EventArgs e)
        {
            rtbLog.SelectionStart = rtbLog.Text.Length;
            rtbLog.ScrollToCaret();
        }

        private void WriteLog(String text)
        {
            rtbLog.Text += text + "\n";
        }
    }
}
