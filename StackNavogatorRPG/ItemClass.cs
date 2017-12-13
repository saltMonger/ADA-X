using System;
using System.Collections.Generic;
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

    public abstract class ConsumableBase : ItemBase
    {
        public int restoreHealth = 0;
        public int restoreMana = 0;
    }

	public class Item_RustySword : EquipableBase {
		public Item_RustySword() {
			itemID = 0;
			itemType = ItemType.Weapon;
			Sprite = UIImage.FromBundle("Item Images/rustySword");
			physicalAttackBoost = 10;
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
            MagicDefenseBoost = 10;
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
            return "+10 Mag Def";
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
            MagicDefenseBoost = 15;
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
            return "+15 Mag Def";
        }
    }

    public class Item_DruidCloak : EquipableBase
    {
        public Item_DruidCloak()
        {
            itemID = 1;
            itemType = ItemType.Chest;
            Sprite = UIImage.FromBundle("Item Images/sorcererCloak");
            physicalDefenseBoost = 9;
            MagicDefenseBoost = 20;
        }
        public override string GetName()
        {
            return "Druid Cloak";
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
            return "+20 Mag Def";
        }
    }

    public class Item_MasterCloak : EquipableBase
    {
        public Item_MasterCloak()
        {
            itemID = 1;
            itemType = ItemType.Chest;
            Sprite = UIImage.FromBundle("Item Images/masterCloak");
            physicalDefenseBoost = 11;
            MagicDefenseBoost = 25;
        }
        public override string GetName()
        {
            return "Master Cloak";
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
            return "+25 Mag Def";
        }
    }

    public class Item_HealthPotion : ConsumableBase
    {
        public Item_HealthPotion()
        {
            itemID = 1;
            itemType = ItemType.Consumable;
            Sprite = UIImage.FromBundle("Item Images/HealthPotion");
            restoreHealth = 20;
        }
        public override string GetName()
        {
            return "Health Potion";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+20 Health";
        }
        public override string GetDescription2()
        {
            return "";
        }
    }

    public class Item_ManaPotion : ConsumableBase
    {
        public Item_ManaPotion()
        {
            itemID = 1;
            itemType = ItemType.Consumable;
            Sprite = UIImage.FromBundle("Item Images/ManaPotion");
            restoreMana = 10;
        }
        public override string GetName()
        {
            return "Mana Potion";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+10 Mana";
        }
        public override string GetDescription2()
        {
            return "";
        }
    }

    public class Item_WarriorBrew : ConsumableBase
    {
        public Item_WarriorBrew()
        {
            itemID = 1;
            itemType = ItemType.Consumable;
            Sprite = UIImage.FromBundle("Item Images/WarriorBrew");
            restoreHealth = 20;
            restoreMana = 10;
        }
        public override string GetName()
        {
            return "Warrior's Brew";
        }
        public override string Use(CharacterBase target)
        {
            return target.GetName() + " equipped the " + GetName() + "!";
        }
        public override string GetDescription1()
        {
            return "+20 Health";
        }
        public override string GetDescription2()
        {
            return "+10 Mana";
        }
    }

    public class ItemGenerator
    {
        public List<ItemBase> Tier1 = new List<ItemBase>();
        public List<ItemBase> Tier2 = new List<ItemBase>();
        public List<ItemBase> Tier3 = new List<ItemBase>();

        Item_HealthPotion healthPotion = new Item_HealthPotion();
        Item_ManaPotion manaPotion = new Item_ManaPotion();
        Item_WarriorBrew warriorBrew = new Item_WarriorBrew();
        Item_BronzeSword bronzeSwd = new Item_BronzeSword();
        Item_IronSword ironSwd = new Item_IronSword();
        Item_SteelSword steelSwd = new Item_SteelSword();
        Item_EnchantedSword enchantedSwd = new Item_EnchantedSword();
        Item_ClothHat clothHat = new Item_ClothHat();
        Item_LeatherHat leatherHat = new Item_LeatherHat();
        Item_IronHelm ironHat = new Item_IronHelm();
        Item_SteelHelm steelHat = new Item_SteelHelm();
        Item_EnchantedHelm enchantedHat = new Item_EnchantedHelm();
        Item_ClothVest clothChest = new Item_ClothVest();
        Item_LeatherVest leatherChest = new Item_LeatherVest();
        Item_IronChest ironChset = new Item_IronChest();
        Item_SteelChest steelChest = new Item_SteelChest();
        Item_EnchantedChest enchantedChest = new Item_EnchantedChest();
        Item_ClothGloves clothGloves = new Item_ClothGloves();
        Item_LeatherGloves leatherGloves = new Item_LeatherGloves();
        Item_IronGauntlets ironGloves = new Item_IronGauntlets();
        Item_SteelGauntlets steelGloves = new Item_SteelGauntlets();
        Item_EnchantedGauntlets enchantedGloves = new Item_EnchantedGauntlets();
        Item_ClothLegs clothLegs = new Item_ClothLegs();
        Item_LeatherLegs leatherLegs = new Item_LeatherLegs();
        Item_IronLegs ironLegs = new Item_IronLegs();
        Item_SteelLegs steelLegs = new Item_SteelLegs();
        Item_EnchantedLegs enchantedLegs = new Item_EnchantedLegs();
        Item_ClothBoots clothBoots = new Item_ClothBoots();
        Item_LeatherBoots leatherBoots = new Item_LeatherBoots();
        Item_IronBoots ironBoots = new Item_IronBoots();
        Item_SteelBoots steelBoots = new Item_SteelBoots();
        Item_EnchantedBoots enchantedBoots = new Item_EnchantedBoots();
        Item_MagicCloak magCloak = new Item_MagicCloak();
        Item_SorcererCloak sorcCloak = new Item_SorcererCloak();
        Item_DruidCloak druidCloak = new Item_DruidCloak();
        Item_MasterCloak masterCloak = new Item_MasterCloak();
        Item_MagicStaff magStaff = new Item_MagicStaff();
        Item_SorcererStaff sorcStaff = new Item_SorcererStaff();
        Item_DruidStaff druidStaff = new Item_DruidStaff();
        Item_MasterStaff masterStaff = new Item_MasterStaff();

        public ItemGenerator()
        {
            Tier1.Add(healthPotion);
            Tier1.Add(manaPotion);
            Tier1.Add(bronzeSwd);
            Tier1.Add(ironSwd);
            Tier1.Add(clothHat);
            Tier1.Add(leatherHat);
            Tier1.Add(ironHat);
            Tier1.Add(clothChest);
            Tier1.Add(leatherChest);
            Tier1.Add(ironChset);
            Tier1.Add(clothGloves);
            Tier1.Add(leatherGloves);
            Tier1.Add(ironGloves);
            Tier1.Add(clothLegs);
            Tier1.Add(leatherLegs);
            Tier1.Add(ironLegs);
            Tier1.Add(clothBoots);
            Tier1.Add(leatherBoots);
            Tier1.Add(ironBoots);
            Tier1.Add(magCloak);
            Tier1.Add(sorcCloak);
            Tier1.Add(magStaff);
            Tier1.Add(sorcStaff);

            Tier2.Add(healthPotion);
            Tier2.Add(manaPotion);
            Tier2.Add(warriorBrew);
            Tier1.Add(ironSwd);
            Tier2.Add(steelSwd);
            Tier2.Add(leatherHat);
            Tier2.Add(ironHat);
            Tier2.Add(steelHat);
            Tier2.Add(leatherChest);
            Tier2.Add(ironChset);
            Tier2.Add(steelChest);
            Tier2.Add(leatherGloves);
            Tier2.Add(ironGloves);
            Tier2.Add(steelGloves);
            Tier2.Add(leatherLegs);
            Tier2.Add(ironLegs);
            Tier2.Add(steelLegs);
            Tier2.Add(leatherBoots);
            Tier2.Add(ironBoots);
            Tier2.Add(steelBoots);
            Tier2.Add(sorcCloak);
            Tier2.Add(druidCloak);
            Tier2.Add(sorcStaff);
            Tier2.Add(druidStaff);

            Tier3.Add(healthPotion);
            Tier3.Add(manaPotion);
            Tier3.Add(warriorBrew);
            Tier3.Add(steelSwd);
            Tier3.Add(enchantedSwd);
            Tier3.Add(ironHat);
            Tier3.Add(steelHat);
            Tier3.Add(enchantedHat);
            Tier3.Add(ironChset);
            Tier3.Add(steelChest);
            Tier3.Add(enchantedChest);
            Tier3.Add(ironGloves);
            Tier3.Add(steelGloves);
            Tier3.Add(enchantedGloves);
            Tier3.Add(ironLegs);
            Tier3.Add(steelLegs);
            Tier3.Add(enchantedLegs);
            Tier3.Add(ironBoots);
            Tier3.Add(steelBoots);
            Tier3.Add(enchantedBoots);
            Tier3.Add(druidCloak);
            Tier3.Add(masterCloak);
            Tier3.Add(druidStaff);
            Tier3.Add(masterStaff);
        }

        public ItemBase GenerateItem(int tier) //spawn a random item in a tier bracket
        {
            int index = 1;
            switch (tier)
            {
                case 1:
                    index = randomBetween(0, Tier1.Count - 1);
                    return Tier1[index];

                case 2:
                    index = randomBetween(0, Tier2.Count - 1);
                    return Tier2[index];

                case 3:
                    index = randomBetween(0, Tier3.Count - 1);
                    return Tier3[index];
            }

            var generatedItem = new Item_RustySword();
            return generatedItem;
        }

        private int randomBetween(int x, int y)
        {
            Random r = new Random();
            int rInt = r.Next(x, y);
            return rInt;
        }

    }
}
