using System;
using UIKit;

namespace StackNavogatorRPG.Enemies
{
    public class Enemy_Rat : EnemyCharacter
    {
        UIImage sprite;

        class Attack_RatBite : AttackBase
        {
            public override int Action(CharacterBase source, CharacterBase target, out string message)
            {
                float damage = 0;
                damage = source.PhysicalAttack - (target.PhysicalDefense/source.PhysicalAttack);
                if (damage < 1)
                    damage = 1;
                target.Health -= (int)damage;
                message = source.GetName() + " bites " + target.GetName() + " and deals " + damage + " damage!";
                return (int)damage;
            }

            public override string GetName()
            {
                return "Bite";
            }
        }

        class RatArmyAttack : AttackBase
        {
            public override int Action(CharacterBase source, CharacterBase target, out string message)
            {
                float damage = 0;
                damage = source.MagicAttack - (target.MagicDefense / source.MagicAttack);
                target.Health -= (int)damage;
                if (damage < 1) { damage = 1; }
                message = source.GetName() + " gathers an army and attacks! -" + damage + " Mana!";

                return (int)damage;
            }

            public override string GetName()
            {
                return "Army attack";
            }
        }

        public Enemy_Rat()
        {
            sprite = UIImage.FromBundle("Enemy Images/rat.png");
            attacks.Add(new Attack_RatBite());
            attacks.Add(new Attack_RatBite());
            attacks.Add(new RatArmyAttack());

            //set stats
            PhysicalAttack = 3;
            PhysicalDefense = 1;
            MagicAttack = 4;
            MagicDefense = 2;
            MaxHealth = 20;
            Health = 20;
            Level = 2;
        }

        public override UIImage GetImage()
        {
            return sprite;
        }

        public override string GetName()
        {
            return "Rat";
        }
    }
}
