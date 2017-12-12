using System;
using Foundation;
using UIKit;

namespace StackNavogatorRPG
{
	public abstract class ItemBase {
		public int itemID;
		public enum ItemType { 
			Weapon, Helm, Chest, Gauntlets, Leg, Boots, Consumable
		}
		public ItemType itemType;

		public UIImage Sprite;
		public abstract string GetName();
		public abstract string Use(CharacterBase target);
        public abstract string GetDescription1();
        public abstract string GetDescription2();
	}

	public abstract class EquipableBase : ItemBase {
		public int physicalDefenseBoost = 0;
		public int physicalAttackBoost = 0;
		public int MagicDefenseBoost = 0;
		public int MagicAttackBoost = 0;

		public virtual AttackBase GetAttack() {
			//If the weapon supplies a unique attack, it goes here
			return null;
		}
	}

	public class Item_RustySword : EquipableBase {
		public Item_RustySword() {
			itemID = 0;
			itemType = ItemType.Weapon;
			Sprite = UIImage.FromBundle("Item Images/rustySword");
			physicalAttackBoost = 15;
		}
		public override string GetName() {
			return "Rusty Sword";
		}
		public override string Use(CharacterBase target) {
            //Equip to sword Slot
            return target.GetName() + " equipped the " + GetName() + "!";
		}
		public override string GetDescription1() {
			return "+10 Phys Atk";
        }
        public override string GetDescription2()
        {
            return "";
        }
	}

    public class Item_BronzeSword : EquipableBase
    {
        public Item_BronzeSword()
        {
            itemID = 0;
            itemType = ItemType.Weapon;
            Sprite = UIImage.FromBundle("Item Images/bronzeSword");
            physicalAttackBoost = 15;
        }
        public override string GetName()
        {
            return "Bronze Sword";
        }
        public override string Use(CharacterBase target)
        {
            //Equip to sword Slot
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+15 Phys Atk";
        }
        public override string GetDescription2()
        {
            return "";
        }
    }

    public class Item_IronSword : EquipableBase
    {
        public Item_IronSword()
        {
            itemID = 0;
            itemType = ItemType.Weapon;
            Sprite = UIImage.FromBundle("Item Images/ironSword");
            physicalAttackBoost = 20;
        }
        public override string GetName()
        {
            return "Iron Sword";
        }
        public override string Use(CharacterBase target)
        {
            //Equip to sword Slot
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+20 Phys Atk";
        }
        public override string GetDescription2()
        {
            return "";
        }
    }

    public class Item_SteelSword : EquipableBase
    {
        public Item_SteelSword()
        {
            itemID = 0;
            itemType = ItemType.Weapon;
            Sprite = UIImage.FromBundle("Item Images/steelSword");
            physicalAttackBoost = 25;
        }
        public override string GetName()
        {
            return "Steel Sword";
        }
        public override string Use(CharacterBase target)
        {
            //Equip to sword Slot
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+25 Phys Atk";
        }
        public override string GetDescription2()
        {
            return "";
        }
    }

    public class Item_EnchantedSword : EquipableBase
    {
        public Item_EnchantedSword()
        {
            itemID = 0;
            itemType = ItemType.Weapon;
            Sprite = UIImage.FromBundle("Item Images/enchantedSword");
            physicalAttackBoost = 20;
            MagicAttackBoost = 10;
        }
        public override string GetName()
        {
            return "Enchanted Sword";
        }
        public override string Use(CharacterBase target)
        {
            //Equip to sword Slot
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+20 Phys Atk";
        }
        public override string GetDescription2()
        {
            return "+10 Mag Atk";
        }
    }

    public class Item_MagicStaff : EquipableBase
    {
        public Item_MagicStaff()
        {
            itemID = 0;
            itemType = ItemType.Weapon;
            Sprite = UIImage.FromBundle("Item Images/magicStaff");
            physicalAttackBoost = 5;
            MagicAttackBoost = 15;
        }
        public override string GetName()
        {
            return "Magic Staff";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+15 Mag Atk";
        }
        public override string GetDescription2()
        {
            return "+5 Phys Atk";
        }
    }

    public class Item_SorcererStaff : EquipableBase
    {
        public Item_SorcererStaff()
        {
            itemID = 0;
            itemType = ItemType.Weapon;
            Sprite = UIImage.FromBundle("Item Images/sorcererStaff");
            physicalAttackBoost = 7;
            MagicAttackBoost = 20;
        }
        public override string GetName()
        {
            return "Sorcerer Staff";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+20 Mag Atk";
        }
        public override string GetDescription2()
        {
            return "+7 Phys Atk";
        }
    }

    public class Item_DruidStaff : EquipableBase
    {
        public Item_DruidStaff()
        {
            itemID = 0;
            itemType = ItemType.Weapon;
            Sprite = UIImage.FromBundle("Item Images/druidStaff");
            physicalAttackBoost = 9;
            MagicAttackBoost = 25;
        }
        public override string GetName()
        {
            return "Druid Staff";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+25 Mag Atk";
        }
        public override string GetDescription2()
        {
            return "+9 Phys Atk";
        }
    }

    public class Item_MasterStaff : EquipableBase
    {
        public Item_MasterStaff()
        {
            itemID = 0;
            itemType = ItemType.Weapon;
            Sprite = UIImage.FromBundle("Item Images/masterStaff");
            physicalAttackBoost = 11;
            MagicAttackBoost = 30;
        }
        public override string GetName()
        {
            return "Master Staff";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+30 Mag Atk";
        }
        public override string GetDescription2()
        {
            return "+11 Phys Atk";
        }
    }

    public class Item_ClothHat : EquipableBase
    {
        public Item_ClothHat()
        {
            itemID = 1;
            itemType = ItemType.Helm;
            Sprite = UIImage.FromBundle("Item Images/clothHelmet");
            physicalDefenseBoost = 10;
        }
        public override string GetName()
        {
            return "Cloth Hat";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+10 Phys Def";
        }
        public override string GetDescription2()
        {
            return "";
        }
    }

    public class Item_LeatherHat : EquipableBase
    {
        public Item_LeatherHat()
        {
            itemID = 1;
            itemType = ItemType.Helm;
            Sprite = UIImage.FromBundle("Item Images/leatherHelmet");
            physicalDefenseBoost = 15;
        }
        public override string GetName()
        {
            return "Leather Hat";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+15 Phys Def";
        }
        public override string GetDescription2()
        {
            return "";
        }
    }

    public class Item_IronHelm : EquipableBase
    {
        public Item_IronHelm()
        {
            itemID = 1;
            itemType = ItemType.Helm;
            Sprite = UIImage.FromBundle("Item Images/ironHelmet");
            physicalDefenseBoost = 20;
        }
        public override string GetName()
        {
            return "Iron Helm";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+20 Phys Def";
        }
        public override string GetDescription2()
        {
            return "";
        }
    }

    public class Item_SteelHelm : EquipableBase
    {
        public Item_SteelHelm()
        {
            itemID = 1;
            itemType = ItemType.Helm;
            Sprite = UIImage.FromBundle("Item Images/steelHelmet");
            physicalDefenseBoost = 25;
        }
        public override string GetName()
        {
            return "Steel Helm";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+25 Phys Def";
        }
        public override string GetDescription2()
        {
            return "";
        }
    }

    public class Item_EnchantedHelm : EquipableBase
    {
        public Item_EnchantedHelm()
        {
            itemID = 1;
            itemType = ItemType.Helm;
            Sprite = UIImage.FromBundle("Item Images/enchantedHelmet");
            physicalDefenseBoost = 20;
            MagicDefenseBoost = 10;
        }
        public override string GetName()
        {
            return "Enchanted Helm";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+20 Phys Def";
        }
        public override string GetDescription2()
        {
            return "+10 Mag Def";
        }
    }

    public class Item_ClothVest : EquipableBase
    {
        public Item_ClothVest()
        {
            itemID = 2;
            itemType = ItemType.Chest;
            Sprite = UIImage.FromBundle("Item Images/clothChest");
            physicalDefenseBoost = 10;
        }
        public override string GetName()
        {
            return "Cloth Vest";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+10 Phys Def";
        }
        public override string GetDescription2()
        {
            return "";
        }
    }

    public class Item_LeatherVest : EquipableBase
    {
        public Item_LeatherVest()
        {
            itemID = 1;
            itemType = ItemType.Chest;
            Sprite = UIImage.FromBundle("Item Images/leatherChest");
            physicalDefenseBoost = 15;
        }
        public override string GetName()
        {
            return "Leather Vest";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+15 Phys Def";
        }
        public override string GetDescription2()
        {
            return "";
        }
    }

    public class Item_IronChest : EquipableBase
    {
        public Item_IronChest()
        {
            itemID = 1;
            itemType = ItemType.Chest;
            Sprite = UIImage.FromBundle("Item Images/ironChest");
            physicalDefenseBoost = 20;
        }
        public override string GetName()
        {
            return "Iron Chest Plate";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+20 Phys Def";
        }
        public override string GetDescription2()
        {
            return "";
        }
    }

    public class Item_SteelChest : EquipableBase
    {
        public Item_SteelChest()
        {
            itemID = 1;
            itemType = ItemType.Chest;
            Sprite = UIImage.FromBundle("Item Images/steelChest");
            physicalDefenseBoost = 25;
        }
        public override string GetName()
        {
            return "Steel Chest Plate";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+25 Phys Def";
        }
        public override string GetDescription2()
        {
            return "";
        }
    }

    public class Item_EnchantedChest : EquipableBase
    {
        public Item_EnchantedChest()
        {
            itemID = 1;
            itemType = ItemType.Chest;
            Sprite = UIImage.FromBundle("Item Images/enchantedChest");
            physicalDefenseBoost = 20;
            MagicDefenseBoost = 20;
        }
        public override string GetName()
        {
            return "Enchanted Chest Plate";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+20 Phys Def";
        }
        public override string GetDescription2()
        {
            return "+10 Mag Def";
        }
    }

    public class Item_ClothGloves : EquipableBase
    {
        public Item_ClothGloves()
        {
            itemID = 3;
            itemType = ItemType.Gauntlets;
            Sprite = UIImage.FromBundle("Item Images/clothGloves");
            physicalDefenseBoost = 5;
        }
        public override string GetName()
        {
            return "Cloth Gloves";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+5 Phys Def";
        }
        public override string GetDescription2()
        {
            return "";
        }
    }

    public class Item_LeatherGloves : EquipableBase
    {
        public Item_LeatherGloves()
        {
            itemID = 3;
            itemType = ItemType.Gauntlets;
            Sprite = UIImage.FromBundle("Item Images/leatherGloves");
            physicalDefenseBoost = 5;
        }
        public override string GetName()
        {
            return "Leather Gloves";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+7 Phys Def";
        }
        public override string GetDescription2()
        {
            return "";
        }
    }

    public class Item_IronGauntlets : EquipableBase
    {
        public Item_IronGauntlets()
        {
            itemID = 1;
            itemType = ItemType.Gauntlets;
            Sprite = UIImage.FromBundle("Item Images/ironGloves");
            physicalDefenseBoost = 9;
        }
        public override string GetName()
        {
            return "Iron Gauntlets";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+9 Phys Def";
        }
        public override string GetDescription2()
        {
            return "";
        }
    }

    public class Item_SteelGauntlets : EquipableBase
    {
        public Item_SteelGauntlets()
        {
            itemID = 1;
            itemType = ItemType.Gauntlets;
            Sprite = UIImage.FromBundle("Item Images/steelGloves");
            physicalDefenseBoost = 11;
        }
        public override string GetName()
        {
            return "Steel Gauntlets";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+11 Phys Def";
        }
        public override string GetDescription2()
        {
            return "";
        }
    }

    public class Item_EnchantedGauntlets : EquipableBase
    {
        public Item_EnchantedGauntlets()
        {
            itemID = 1;
            itemType = ItemType.Gauntlets;
            Sprite = UIImage.FromBundle("Item Images/enchantedGloves");
            physicalDefenseBoost = 9;
            MagicDefenseBoost = 5;
        }
        public override string GetName()
        {
            return "Enchanted Gauntlets";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+9 Phys Def";
        }
        public override string GetDescription2()
        {
            return "+5 Phys Def";
        }
    }

    public class Item_ClothLegs : EquipableBase
    {
        public Item_ClothLegs()
        {
            itemID = 4;
            itemType = ItemType.Leg;
            Sprite = UIImage.FromBundle("Item Images/clothLeg");
            physicalDefenseBoost = 5;
        }
        public override string GetName()
        {
            return "Cloth Leg Pads";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+5 Phys Def";
        }
        public override string GetDescription2()
        {
            return "";
        }
    }

    public class Item_LeatherLegs : EquipableBase
    {
        public Item_LeatherLegs()
        {
            itemID = 1;
            itemType = ItemType.Leg;
            Sprite = UIImage.FromBundle("Item Images/leatherLeg");
            physicalDefenseBoost = 7;
        }
        public override string GetName()
        {
            return "Leather Leg Pads";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+7 Phys Def";
        }
        public override string GetDescription2()
        {
            return "";
        }
    }

    public class Item_IronLegs : EquipableBase
    {
        public Item_IronLegs()
        {
            itemID = 1;
            itemType = ItemType.Leg;
            Sprite = UIImage.FromBundle("Item Images/ironLeg");
            physicalDefenseBoost = 9;
        }
        public override string GetName()
        {
            return "Iron Leg Guards";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+9 Phys Def";
        }
        public override string GetDescription2()
        {
            return "";
        }
    }

    public class Item_SteelLegs : EquipableBase
    {
        public Item_SteelLegs()
        {
            itemID = 1;
            itemType = ItemType.Leg;
            Sprite = UIImage.FromBundle("Item Images/steelLeg");
            physicalDefenseBoost = 11;
        }
        public override string GetName()
        {
            return "Steel Leg Guards";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+11 Phys Def";
        }
        public override string GetDescription2()
        {
            return "";
        }
    }

    public class Item_EnchantedLegs : EquipableBase
    {
        public Item_EnchantedLegs()
        {
            itemID = 1;
            itemType = ItemType.Leg;
            Sprite = UIImage.FromBundle("Item Images/enchantedLeg");
            physicalDefenseBoost = 9;
            MagicDefenseBoost = 5;
        }
        public override string GetName()
        {
            return "Enchanted Leg Guards";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+9 Phys Def";
        }
        public override string GetDescription2()
        {
            return "+5 Mag Def";
        }
    }

    public class Item_ClothBoots : EquipableBase
    {
        public Item_ClothBoots()
        {
            itemID = 4;
            itemType = ItemType.Boots;
            Sprite = UIImage.FromBundle("Item Images/clothBoots");
            physicalDefenseBoost = 5;
        }
        public override string GetName()
        {
            return "Cloth Boots";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+5 Phys Def";
        }
        public override string GetDescription2()
        {
            return "";
        }
    }

    public class Item_LeatherBoots : EquipableBase
    {
        public Item_LeatherBoots()
        {
            itemID = 1;
            itemType = ItemType.Boots;
            Sprite = UIImage.FromBundle("Item Images/leatherBoots");
            physicalDefenseBoost = 7;
        }
        public override string GetName()
        {
            return "Leather Boots";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+7 Phys Def";
        }
        public override string GetDescription2()
        {
            return "";
        }
    }

    public class Item_IronBoots : EquipableBase
    {
        public Item_IronBoots()
        {
            itemID = 1;
            itemType = ItemType.Boots;
            Sprite = UIImage.FromBundle("Item Images/ironBoots");
            physicalDefenseBoost = 9;
        }
        public override string GetName()
        {
            return "Iron Boots";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+9 Phys Def";
        }
        public override string GetDescription2()
        {
            return "";
        }
    }

    public class Item_SteelBoots : EquipableBase
    {
        public Item_SteelBoots()
        {
            itemID = 1;
            itemType = ItemType.Boots;
            Sprite = UIImage.FromBundle("Item Images/steelBoots");
            physicalDefenseBoost = 11;
        }
        public override string GetName()
        {
            return "Steel Boots";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+11 Phys Def";
        }
        public override string GetDescription2()
        {
            return "";
        }
    }

    public class Item_EnchantedBoots : EquipableBase
    {
        public Item_EnchantedBoots()
        {
            itemID = 1;
            itemType = ItemType.Boots;
            Sprite = UIImage.FromBundle("Item Images/enchantedBoots");
            physicalDefenseBoost = 9;
            MagicDefenseBoost = 5;
        }
        public override string GetName()
        {
            return "Enchanted Boots";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+9 Phys Def";
        }
        public override string GetDescription2()
        {
            return "+5 Mag Def";
        }
    }

    public class Item_MagicCloak : EquipableBase
    {
        public Item_MagicCloak()
        {
            itemID = 1;
            itemType = ItemType.Chest;
            Sprite = UIImage.FromBundle("Item Images/magicCloak");
            physicalDefenseBoost = 5;
            MagicDefenseBoost = 15;
        }
        public override string GetName()
        {
            return "Magic Cloak";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+5 Phys Def";
        }
        public override string GetDescription2()
        {
            return "+15 Mag Def";
        }
    }

    public class Item_SorcererCloak : EquipableBase
    {
        public Item_SorcererCloak()
        {
            itemID = 1;
            itemType = ItemType.Chest;
            Sprite = UIImage.FromBundle("Item Images/sorcererCloak");
            physicalDefenseBoost = 7;
            MagicDefenseBoost = 20;
        }
        public override string GetName()
        {
            return "Sorcerer Cloak";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+7 Phys Def";
        }
        public override string GetDescription2()
        {
            return "+20 Mag Def";
        }
    }

    //TODO: druid's cloak, master's cloak, potions 

    public class Item
    {
        private int itemID;         //0-40
        private int itemTier;       //1-3
        public bool equipped;

        public string name;
        public string image;
        public int slot;
        public int[] effectStats = new int[6];


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
