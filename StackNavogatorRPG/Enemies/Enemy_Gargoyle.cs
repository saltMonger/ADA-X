using System;
using UIKit;

namespace StackNavogatorRPG.Enemies
{
    public class Enemy_Gargoyle : EnemyCharacter
    {
        UIImage sprite;

        class Attack_GargoyleScratch : AttackBase
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

        class GargoyleWait:AttackBase{
            public override int Action(CharacterBase source, CharacterBase target, out string message)
            {
                message = source.GetName() + " stands there... menacingly!";
                return 0;
            }

            public override string GetName()
            {
                return "Wait";
            }
        }

        public Enemy_Gargoyle()
        {
            sprite = UIImage.FromBundle("Enemy Images/gargoyle.png");
            attacks.Add(new GargoyleWait());
            attacks.Add(new Attack_GargoyleScratch());

            //set stats
            PhysicalAttack = 5;
            PhysicalDefense = 3;
            MagicAttack = 0;
            MagicDefense = 1;
            MaxHealth = 20;
            Health = 20;
            //Level = 1;
        }

        public override UIImage GetImage()
        {
            return sprite;
        }

        public override string GetName()
        {
            return "Gargoyle";
        }
    }
}
