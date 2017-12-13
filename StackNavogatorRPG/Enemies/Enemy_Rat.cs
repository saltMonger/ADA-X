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
                damage = source.PhysicalAttack - target.PhysicalDefense - 1;
                target.Health -= (int)damage;
                message = source.GetName() + " bites " + target.GetName() + " and deals " + damage + " damage!";
                if (damage < 0)
                    damage = 0;
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
                int damage = source.MagicAttack - target.MagicDefense;
                if (damage < 0) { damage = 0; }
                message = source.GetName() + " gathers an army and attacks! -" + damage + " Mana!";

                return damage;
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
            PhysicalDefense = 0;
            MagicAttack = 6;
            MagicDefense = 4;
            MaxHealth = 10;
            Health = 10;
            //Level = 1;
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
