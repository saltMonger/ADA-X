﻿using System;
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
                damage = source.PhysicalAttack - source.PhysicalDefense;
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

        public Enemy_Goblin()
        {
            sprite = UIImage.FromBundle("Enemy Images/goblin.png");
            attacks.Add(new Attack_Punch());
            attacks.Add(new Attack_GoblinScratch());

            //set stats
            PhysicalAttack = 5;
            PhysicalDefense = 4;
            MagicAttack = 0;
            MagicDefense = 0;
            MaxHealth = 25;
            Health = 25;
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
