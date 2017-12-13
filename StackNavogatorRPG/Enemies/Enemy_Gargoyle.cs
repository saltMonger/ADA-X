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
                damage = source.PhysicalAttack - (target.PhysicalDefense / source.PhysicalAttack);
                if (damage < 1)
                    damage = 1;
                target.Health -= (int)damage;
                message = source.GetName() + " hit " + target.GetName() + " and dealt " + damage + " damage!";
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
            PhysicalAttack = 10;
            PhysicalDefense = 10;
            MagicAttack = 0;
            MagicDefense = 0;
            MaxHealth = 40;
            Health = 40;
            Level = 4;
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
