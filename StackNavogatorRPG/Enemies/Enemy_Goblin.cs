using System;
using UIKit;

namespace StackNavogatorRPG.Enemies
{
    public class Enemy_Goblin: EnemyCharacter
    {
        UIImage sprite;

        class Attack_GoblinScratch : AttackBase
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

        public Enemy_Goblin()
        {
            sprite = UIImage.FromBundle("Enemy Images/goblin.png");
            attacks.Add(new Attack_Punch());
            attacks.Add(new Attack_GoblinScratch());

            //set stats
            PhysicalAttack = 10;
            PhysicalDefense = 4;
            MagicAttack = 5;
            MagicDefense = 2;
            MaxHealth = 30;
            Health = 30;
            Level = 3;
        }

        public override UIImage GetImage()
        {
            return sprite;
        }

        public override string GetName()
        {
            return "Goblin";
        }
    }
}
