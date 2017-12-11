using System;
using Foundation;
using UIKit;

namespace StackNavogatorRPG
{
    public class Item
    {
        private int itemID;         //0-40
        private int itemTier;       //1-3
        public bool equipped;

        public string name;
        public string image;
        public int slot;
        public int[] effectStats = new int[6];

        /*
         * effect stats:
         *  [0] - HP
         *  [1] - Stamina
         *  [2] - Phys Attack
         *  [3] - Phys Defense
         *  [4] - Mag Attack
         *  [5] - Mag Defense
         *  
         * slot:
         *  0 - potion
         *  1 - weapon
         *  2 - helm
         *  3 - chest
         *  4 - gauntlets
         *  5 - leg
         *  6 - boots
         */

        public void SetItem(int id) // spawn specific item based on ID
        {
            itemID = id;
            setStats();
        }

        public Item(int tier) //spawn a random item in a tier bracket
        {
            itemTier = tier;
            if (tier == 1)
            {
                itemID = randomBetween(0, 24);
            }
            else if (tier == 2)
            {
                itemID = randomBetween(10, 32);
            }
            else if (tier == 3)
            {
                itemID = randomBetween(19, 40);
            }

            setStats();
        }

        //restores hp/stamina or equips items and boosts character stats
        void Use(CharacterBase target)
        {
            //
        }

        private int randomBetween(int x, int y)
        {
            Random r = new Random();
            int rInt = r.Next(x, y);
            return rInt;
        }

        private void setStats() // item library hardcoded stats
        {
            switch (itemID)
            {
                //Tier 1:
                case 0:
                    name = "Rusty Sword";
                    image = "rustySword.png";
                    slot = 1;
                    effectStats = new int[] {0, 0, 15, 0, 0, 0};
                    break;
                case 1:
                    name = "Cloth Hat";
                    image = "clothHelmet.png";
                    slot = 2;
                    effectStats = new int[] { 0, 0, 0, 15, 0, 0 };
                    break;
                case 2:
                    name = "Cloth Vest";
                    image = "clothChest.png";
                    slot = 3;
                    effectStats = new int[] { 0, 0, 0, 10, 0, 0 };
                    break;
                case 3:
                    name = "Cloth Gloves";
                    image = "clothGloves.png";
                    slot = 4;
                    effectStats = new int[] { 0, 0, 0, 5, 0, 0 };
                    break;
                case 4:
                    name = "Cloth Leg Padding";
                    image = "clothLeg.png";
                    slot = 5;
                    effectStats = new int[] { 0, 0, 0, 5, 0, 0 };
                    break;
                case 5:
                    name = "Cloth Boots";
                    image = "clothBoots.png";
                    slot = 6;
                    effectStats = new int[] { 0, 0, 0, 5, 0, 0 };
                    break;
                case 6:
                    name = "Magic Staff";
                    image = "magicStaff.png";
                    slot = 1;
                    effectStats = new int[] { 0, 0, 0, 0, 30, 0 };
                    break;
                case 7:
                    name = "Magic Cloak";
                    image = "magicCloak.png";
                    slot = 3;
                    effectStats = new int[] { 0, 0, 0, 2, 0, 10 };
                    break;
                case 8:
                    name = "Health Potion";
                    image = "HealthPotion.png";
                    slot = 0;
                    effectStats = new int[] { 50, 0, 0, 0, 0, 0 };
                    break;
                case 9:
                    name = "Mana Potion";
                    image = "ManaPotion.png";
                    slot = 0;
                    effectStats = new int[] { 0, 50, 0, 0, 0, 0 };
                    break;
                //Tier 2:
                case 10:
                    name = "Bronze Sword";
                    image = "bronzeSword.png";
                    slot = 1;
                    effectStats = new int[] { 0, 0, 20, 0, 0, 0 };
                    break;
                case 11:
                    name = "Leather Hat";
                    image = "leatherHelmet.png";
                    slot = 2;
                    effectStats = new int[] { 0, 0, 0, 15, 0, 0 };
                    break;
                case 12:
                    name = "Leather Vest";
                    image = "leatherChest.png";
                    slot = 3;
                    effectStats = new int[] { 0, 0, 0, 15, 0, 0 };
                    break;
                case 13:
                    name = "Leather Gloves";
                    image = "leatherGloves.png";
                    slot = 4;
                    effectStats = new int[] { 0, 0, 0, 7, 0, 0 };
                    break;
                case 14:
                    name = "Leather Leg Padding";
                    image = "leatherLeg.png";
                    slot = 5;
                    effectStats = new int[] { 0, 0, 0, 7, 0, 0 };
                    break;
                case 15:
                    name = "Leather Boots";
                    image = "leatherBoots.png";
                    slot = 6;
                    effectStats = new int[] { 0, 0, 0, 7, 0, 0 };
                    break;
                case 16:
                    name = "Warrior's Brew";
                    image = "WarriorBrew.png";
                    slot = 0;
                    effectStats = new int[] { 50, 50, 0, 0, 0, 0 };
                    break;
                case 17:
                    name = "Sorcerer's Staff";
                    image = "sorcererStaff.png";
                    slot = 1;
                    effectStats = new int[] { 0, 0, 0, 0, 40, 0 };
                    break;
                case 18:
                    name = "Sorcerer's Cloak";
                    image = "sorcererCloak.png";
                    slot = 3;
                    effectStats = new int[] { 0, 0, 0, 4, 0, 20 };
                    break;
                //Tier 3:
                case 19:
                    name = "Iron Sword";
                    image = "ironSword.png";
                    slot = 1;
                    effectStats = new int[] { 0, 0, 25, 0, 0, 0 };
                    break;
                case 20:
                    name = "Iron Helmet";
                    image = "ironSword.png";
                    slot = 2;
                    effectStats = new int[] { 0, 0, 0, 20, 0, 0 };
                    break;
                case 21:
                    name = "Iron Chest Plate";
                    image = "ironChest.png";
                    slot = 3;
                    effectStats = new int[] { 0, 0, 0, 20, 0, 0 };
                    break;
                case 22:
                    name = "Iron Gauntlets";
                    image = "ironGloves.png";
                    slot = 4;
                    effectStats = new int[] { 0, 0, 0, 9, 0, 0 };
                    break;
                case 23:
                    name = "Iron Leg Armor";
                    image = "ironLeg.png";
                    slot = 5;
                    effectStats = new int[] { 0, 0, 0, 9, 0, 0 };
                    break;
                case 24:
                    name = "Iron Boots";
                    image = "ironBoots.png";
                    slot = 6;
                    effectStats = new int[] { 0, 0, 0, 9, 0, 0 };
                    break;
                //End of Tier 1
                case 25:
                    name = "Druid's Staff";
                    image = "druidStaff.png";
                    slot = 1;
                    effectStats = new int[] { 0, 0, 0, 0, 50, 0 };
                    break;
                case 26:
                    name = "Druid's Cloak";
                    image = "druidStaff.png";
                    slot = 3;
                    effectStats = new int[] { 0, 0, 0, 6, 0, 30 };
                    break;
                case 27:
                    name = "Steel Sword";
                    image = "steelSword.png";
                    slot = 1;
                    effectStats = new int[] { 0, 0, 30, 0, 0, 0 };
                    break;
                case 28:
                    name = "Steel Helmet";
                    image = "steelHelmet.png";
                    slot = 2;
                    effectStats = new int[] { 0, 0, 0, 25, 0, 0 };
                    break;
                case 29:
                    name = "Steel Chest Plate";
                    image = "steelChest.png";
                    slot = 3;
                    effectStats = new int[] { 0, 0, 0, 25, 0, 0 };
                    break;
                case 30:
                    name = "Steel Gauntlets";
                    image = "steelGloves.png";
                    slot = 4;
                    effectStats = new int[] { 0, 0, 0, 11, 0, 0 };
                    break;
                case 31:
                    name = "Steel Leg Armor";
                    image = "steelLeg.png";
                    slot = 5;
                    effectStats = new int[] { 0, 0, 0, 11, 0, 0 };
                    break;
                case 32:
                    name = "Steel Boots";
                    image = "steelBoots.png";
                    slot = 6;
                    effectStats = new int[] { 0, 0, 0, 11, 0, 0 };
                    break;
                //End of Tier 2
                case 33:
                    name = "Master's Staff";
                    image = "masterStaff.png";
                    slot = 1;
                    effectStats = new int[] { 0, 0, 0, 0, 60, 0 };
                    break;
                case 34:
                    name = "Master's Cloak";
                    image = "masterCloak.png";
                    slot = 3;
                    effectStats = new int[] { 0, 0, 0, 8, 0, 40 };
                    break;
                case 35:
                    name = "Enchanted Sword";
                    image = "enchantedSword.png";
                    slot = 1;
                    effectStats = new int[] { 0, 0, 25, 0, 15, 0 };
                    break;
                case 36:
                    name = "Enchanted Helmet";
                    image = "enchantedHelmet.png";
                    slot = 2;
                    effectStats = new int[] { 0, 0, 0, 20, 0, 10 };
                    break;
                case 37:
                    name = "Enchanted Chest Plate";
                    image = "enchantedChest.png";
                    slot = 3;
                    effectStats = new int[] { 0, 0, 0, 20, 0, 10 };
                    break;
                case 38:
                    name = "Enchanted Gauntlets";
                    image = "enchantedGloves.png";
                    slot = 4;
                    effectStats = new int[] { 0, 0, 0, 9, 0, 5 };
                    break;
                case 39:
                    name = "Enchanted Leg Armor";
                    image = "enchantedLeg.png";
                    slot = 5;
                    effectStats = new int[] { 0, 0, 0, 9, 0, 5 };
                    break;
                case 40:
                    name = "Enchanted Boots";
                    image = "enchantedBoots.png";
                    slot = 6;
                    effectStats = new int[] { 0, 0, 0, 9, 0, 5 };
                    break;
                //End of Tier 3
            }
        }        
    }
}
