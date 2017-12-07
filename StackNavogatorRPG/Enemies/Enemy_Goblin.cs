using System;
using UIKit;

namespace StackNavogatorRPG.Enemies
{
    public class Enemy_Goblin: EnemyCharacter
    {
        UIImage sprite;

        class Attack_GoblinPunch : AttackBase
        {
            public override int Action(CharacterBase source, CharacterBase target, out string message)
            {
                int damage = 0;
                damage = source.PhysicalAttack - target.PhysicalDefense + 2;
                target.Health -= damage;
                message = source.GetName() + " punched " + target.GetName() + "with its goblin fist and dealt " + damage + " damage!";
                return damage;
            }

            public override string GetName()
            {
                return "Goblin Punch";
            }
        }

        public Enemy_Goblin()
        {
            Console.WriteLine("Golbin Loaded");
            sprite = UIImage.FromBundle("Enemy Images/goblin.png");
            attacks.Add(new Attack_Punch());
            attacks.Add(new Attack_GoblinPunch());

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
            return "Goblin";
        }
    }
}
