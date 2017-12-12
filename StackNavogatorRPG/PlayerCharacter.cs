using System;
using System.Collections.Generic;
namespace StackNavogatorRPG
{
    public class PlayerCharacter : CharacterBase
    {
        public List<AttackBase> attacks = new List<AttackBase>();
        public List<ItemBase> equipment = new List<ItemBase>();
        public List<ItemBase> bag = new List<ItemBase>();

        public PlayerCharacter()
        {
            //test
            attacks.Add(new Attack_Punch());
            attacks.Add(new Attack_Magic());
            attacks.Add(new Attack_Healing());

            Equipment = new List<EquipableBase>();
            for (int i = 0; i < 6; i++) {
                Equipment.Add(null);
            }
            Inventory = new List<ItemBase>();

            //test inventory
            Inventory.Add(new Item_RustySword());
        }

        void swapEquipment(int targetSlot, int sourceSlot){
            if(Equipment[targetSlot] == null){
                Equipment[targetSlot] = (EquipableBase)Inventory[sourceSlot];
                Inventory.RemoveAt(sourceSlot);
            }else{
                var temp = Equipment[targetSlot];
                Equipment[targetSlot] = (EquipableBase)Inventory[sourceSlot];
                Inventory[sourceSlot] = temp;
            }
        }

        public string UseItem(int itemSlot, CharacterBase source, CharacterBase target = null)
        {
            string str = Inventory[itemSlot].Use(source);
            if (Inventory[itemSlot].itemType == ItemBase.ItemType.Consumable)
            {
                Inventory.RemoveAt(itemSlot);
            }
            else if (Inventory[itemSlot].itemType == ItemBase.ItemType.Boots)
            {
                swapEquipment((int)ItemBase.ItemType.Boots, itemSlot);
            }
            else if (Inventory[itemSlot].itemType == ItemBase.ItemType.Weapon)
            {
                swapEquipment((int)ItemBase.ItemType.Weapon, itemSlot);

            }
            else if (Inventory[itemSlot].itemType == ItemBase.ItemType.Chest)
            {
                swapEquipment((int)ItemBase.ItemType.Chest, itemSlot);
            }
            else if (Inventory[itemSlot].itemType == ItemBase.ItemType.Gauntlets)
            {
                swapEquipment((int)ItemBase.ItemType.Gauntlets, itemSlot);
            }
            else if (Inventory[itemSlot].itemType == ItemBase.ItemType.Helm)
            {
                swapEquipment((int)ItemBase.ItemType.Helm, itemSlot);
            }else{
                swapEquipment((int)ItemBase.ItemType.Leg, itemSlot);
            }

            return str;
        }

        public override void LevelUp()
        {
            //increase stats

        }

        public override string GetName()
        {
            return "You";
        }

        public void addEquipment(ItemBase item)
        {
            bool replaced = false;
            foreach (var i in equipment)
            {
                if (i.itemType == item.itemType)
                {
                    bag.Add(item);
                    equipment.Remove(i);
                    equipment.Add(item);
                    replaced = true;
                    bag.Remove(item);
                    break;
                }
            }
            if (!replaced)
            {
                equipment.Add(item);
                bag.Remove(item);
            }
                
        }

    }
}
