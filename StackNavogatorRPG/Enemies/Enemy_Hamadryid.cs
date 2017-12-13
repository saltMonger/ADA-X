using System;
using UIKit;

namespace StackNavogatorRPG.Enemies
{
    public class Enemy_Hamadryid : EnemyCharacter
    {
        UIImage sprite;

        class Attack_Scratch : AttackBase
        {
            public override int Action(CharacterBase source, CharacterBase target, out string message)
            {
                float damage = 0;
                damage = source.PhysicalAttack - source.PhysicalAttack / (target.PhysicalDefense * 5);
                target.Health -= (int)damage;
                message = source.GetName() + " hit " + target.GetName() + " and dealt " + damage + " damage!";
                if (damage < 0)
                    damage = 0;
                return (int)damage;
            }

            public override string GetName()
            {
                return "Scratch";
            }
        }

        class Attack_Absorb : AttackBase
        {
            public override int Action(CharacterBase source, CharacterBase target, out string message)
            {
                float damage = 0;
                damage = source.MagicAttack - source.MagicDefense;
                if (damage < 0)
                    damage = 0;
                int heal = (int)(damage / 3);
                target.Health -= (int)damage;

                source.Health += heal;
                message = source.GetName() + " absorbed health from " + target.GetName() + " and heals itself by " + heal + " health!";

                return (int)damage;
            }

            public override string GetName()
            {
                return "Absorb";
            }
        }

        public Enemy_Hamadryid()
        {
            sprite = UIImage.FromBundle("Enemy Images/hamadryad.png");
            attacks.Add(new Attack_Scratch());
            attacks.Add(new Attack_Scratch());
            attacks.Add(new Attack_Magic());
            attacks.Add(new Attack_Magic());
            attacks.Add(new Attack_Absorb());
            attacks.Add(new Attack_Healing());

            //set stats
            PhysicalAttack = 4;
            PhysicalDefense = 10;
            MagicAttack = 8;
            MagicDefense = 12;
            MaxHealth = 50;
            Health = 50;
            //Level = 1;
        }

        public override UIImage GetImage()
        {
            return sprite;
        }

        public override string GetName()
        {
            return "Hamadryid";
        }
    }
}
