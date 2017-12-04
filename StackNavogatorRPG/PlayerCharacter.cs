using System;
using System.Collections.Generic;
namespace StackNavogatorRPG
{
    public class PlayerCharacter : CharacterBase
    {
        public List<AttackBase> attacks = new List<AttackBase>();

        public PlayerCharacter()
        {
            //test
            attacks.Add(new Attack_Punch());
            attacks.Add(new Attack_Magic());
            attacks.Add(new Attack_Healing());
            Name = "Test Boi";
        }

        public override void LevelUp()
        {
            //increase stats
        }

        public override void Attack(AttackBase attack, CharacterBase target)
        {
            int damage = attack.Action(this, target);
            Console.WriteLine(Name + ": " + PhysicalAttack + " -> " + target.Name + ": " + target.PhysicalDefense + ": " + damage);
        }
    }
}
