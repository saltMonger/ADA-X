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
            UpdateStats();

        }

        void equipItem(ItemBase item){
            if (item.itemType != ItemBase.ItemType.Consumable)
            {
                bool replaced = false;
                foreach (var i in equipment)
                {
                    if (i.itemType == item.itemType)
                    {
                        replaced = true;

                        bag.Add(i);
                        equipment.Remove(i);
                        equipment.Add(item);
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
            else
            {
                bag.Remove(item);
                drinkPotion(item as ConsumableBase);
            }
            UpdateStats();
        }

        public string UseItem(int itemSlot, CharacterBase source, CharacterBase target = null)
        {
            string msg = "";
            if (bag[itemSlot].itemType == ItemBase.ItemType.Consumable)
            {
                msg = "You drank a " + bag[itemSlot].GetName() + "!";
            }
            else
            {
                msg = "You equipped your " + bag[itemSlot].GetName() + "!";
            }
            equipItem(bag[itemSlot]);

            return msg;
        }

        public override void LevelUp()
        {
            Level++;
            Experience = 0;
            ExperienceToNextLevel = 10 + (4 * Level);
            UpdateStats();
            Health = MaxHealth;
            Stamina = MaxStamina;
        }

        public override string GetName()
        {
            return "You";
        }

        public void drinkPotion(ConsumableBase potion)
        {
            Health = Health + potion.restoreHealth;
            Stamina = Stamina + potion.restoreMana;

            if (Health > MaxHealth)
                Health = MaxHealth;
            if (Stamina > MaxStamina)
                Stamina = MaxStamina;
        }

        public void UpdateStats()
        {
            int pAttackBoost = 0;
            int pDefenseBoost = 0;
            int mAttackBoost = 0;
            int mDefenseBoost = 0;

            foreach (EquipableBase i in equipment)
            {
                pAttackBoost += i.physicalAttackBoost + (Level * 5) + 5;
                pDefenseBoost += i.physicalDefenseBoost + (Level * 5) + 2;
                mAttackBoost += i.MagicAttackBoost + (Level * 5) + 10;
                mDefenseBoost += i.MagicDefenseBoost + (Level * 5);
            }

            PhysicalAttack = pAttackBoost;
            PhysicalDefense = pDefenseBoost;
            MagicAttack = mAttackBoost;
            MagicDefense = mDefenseBoost;

            MaxHealth = 20 + (Level * 5);
            MaxStamina = 10 + (Level * 2);
        }

    }
}
