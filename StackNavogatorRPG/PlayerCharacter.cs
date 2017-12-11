using System;
using System.Collections.Generic;
namespace StackNavogatorRPG
{
    public class PlayerCharacter : CharacterBase
    {
        public List<AttackBase> attacks = new List<AttackBase>();
        public List<Item> equipment = new List<Item>();
        public List<Item> bag = new List<Item>();

        public PlayerCharacter()
        {
            //test
            attacks.Add(new Attack_Punch());
            attacks.Add(new Attack_Magic());
            attacks.Add(new Attack_Healing());
        }

        public override void LevelUp()
        {
            //increase stats
        }

        public override string GetName()
        {
            return "You";
        }

        public void addEquipment(Item item)
        {
            bool replaced = false;
            foreach (var i in equipment)
            {
                if (i.slot == item.slot)
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
