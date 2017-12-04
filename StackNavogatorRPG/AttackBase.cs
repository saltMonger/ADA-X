using System;
namespace StackNavogatorRPG
{
    //base
    public abstract class AttackBase
    {
        public AttackBase()
        {
        }

        abstract public string GetName();
        abstract public int Action(CharacterBase source, CharacterBase target); //returns damage/healing done
    }

    public class Attack_Punch: AttackBase{
        public override int Action(CharacterBase source, CharacterBase target)
        {
            int damage = 0;
            damage = source.PhysicalAttack - target.PhysicalDefense;
            target.Health -= damage;
            return damage;
        }
        public override string GetName()
        {
            return "Basic Punch";
        }
    }

    public class Attack_Magic : AttackBase
    {
        public override int Action(CharacterBase source, CharacterBase target)
        {
            int damage = 0;
            damage = source.MagicAttack - target.MagicDefense;
            target.Health -= damage;
            return damage;
        }
        public override string GetName()
        {
            return "Basic Magic";
        }
    }

    public class Attack_Healing : AttackBase
    {
        public override int Action(CharacterBase source, CharacterBase target)
        {
            int damage = 0;
            damage = source.PhysicalAttack - target.PhysicalDefense;
            target.Health -= damage;
            return damage;
        }
        public override string GetName()
        {
            return "Basic Heal";
        }
    }
}