using System;
namespace StackNavogatorRPG
{
    //base
    public abstract class AttackBase
    {
        public AttackBase()
        {
        }

        public string ActionDescription;
        abstract public string GetName();
        abstract public int Action(CharacterBase source, CharacterBase target, out string message); //returns damage/healing done
        public virtual int GetManaCost(){
            return 0;
        }
    }

    public class Attack_Punch: AttackBase{
        public override int Action(CharacterBase source, CharacterBase target, out string message)
        {
            int damage = 0;
            damage = source.PhysicalAttack - target.PhysicalDefense;
            target.Health -= damage;
            message = source.GetName() + " punched " + target.GetName() + " and dealt " + damage + " damage!";
            return damage;
        }
        public override string GetName()
        {
            return "Basic Punch";
        }
    }

    public class Attack_Magic : AttackBase
    {
        public override int Action(CharacterBase source, CharacterBase target, out string message)
        {
            int damage = 0;
            damage = source.MagicAttack - target.MagicDefense;
            target.Health -= damage;
            message = source.GetName() + " cast a spell on " + target.GetName() + " and dealt " + damage + " damage!";
            return damage;
        }
        public override string GetName()
        {
            return "Basic Magic";
        }
        public override int GetManaCost()
        {
            return 3;
        }
    }

    public class Attack_Healing : AttackBase
    {
        public override int Action(CharacterBase source, CharacterBase target, out string message)
        {
            int heal = 0;
            heal = source.MagicAttack + 5;
            source.Health += heal;
            message = source.GetName() + " recovered " + heal + " health!";
            return heal;
        }
        public override string GetName()
        {
            return "Basic Heal";
        }
        public override int GetManaCost()
        {
            return 5;
        }
    }
}