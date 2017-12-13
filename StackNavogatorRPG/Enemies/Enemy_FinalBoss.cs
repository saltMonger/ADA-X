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
                damage = source.PhysicalAttack - source.PhysicalDefense;
                target.Health -= (int)damage;
                message = source.GetName() + " burns you " + target.GetName() + " and deals " + damage + " damage!";
                if (damage < 0)
                    damage = 0;
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
            PhysicalAttack = 30;
            PhysicalDefense = 15;
            MagicAttack = 40;
            MagicDefense = 30;
            MaxHealth = 200;
            Health = 200;
            //Level = 1;
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
    }
}