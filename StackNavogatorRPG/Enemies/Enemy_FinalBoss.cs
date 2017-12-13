using UIKit;

namespace StackNavogatorRPG.Enemies
{
    public class Enemy_FinalBoss : EnemyCharacter
    {
        UIImage sprite;

        class Attack_FinalBossScratch : AttackBase
        {
            public override int Action(CharacterBase source, CharacterBase target, out string message)
            {
                float damage = 0;
                damage = source.PhysicalAttack - (target.PhysicalDefense / source.PhysicalAttack);
                if (damage < 1)
                    damage = 1;
                target.Health -= (int)damage;
                message = source.GetName() + " burns you " + target.GetName() + " and deals " + damage + " damage!";
                return (int)damage;
            }

            public override string GetName()
            {
                return "Hellfire";
            }
        }

        public Enemy_FinalBoss()
        {
            sprite = UIImage.FromBundle("Enemy Images/DemonKing.png");
            attacks.Add(new Attack_Punch());
            attacks.Add(new Attack_FinalBossScratch());
            attacks.Add(new Attack_Healing());

            //set stats
            PhysicalAttack = 20;
            PhysicalDefense = 10;
            MagicAttack = 20;
            MagicDefense = 10;
            MaxHealth = 100;
            Health = 100;
            Level = 10;
        }

        public override UIImage GetImage()
        {
            return sprite;
        }

        public override string GetName()
        {
            return "Demon King";
        }
        public override string GetIntro()
        {
            return GetName() + " appears before you...";
        }

        public override bool IsFinalBoss()
        {
            return true;
        }
    }
}