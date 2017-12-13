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
            float damage = 0;
            damage = source.PhysicalAttack - source.PhysicalAttack/(target.PhysicalDefense*5);
            target.Health -= (int)damage;
            message = source.GetName() + " hit " + target.GetName() + " and dealt " + damage + " damage!";
            if (damage < 1)
                damage = 1;
            return (int)damage;
        }
        public override string GetName()
        {
            return "Swing Weapon";
        }
    }

    public class Attack_Magic : AttackBase
    {
        public override int Action(CharacterBase source, CharacterBase target, out string message)
        {
            float damage = 0;
            damage = source.MagicAttack - source.MagicAttack / (target.MagicDefense * 5);
            target.Health -= (int)damage;
            message = source.GetName() + " cast a spell on " + target.GetName() + " and dealt " + damage + " damage!";
            if (damage < 1)
                damage = 1;
            source.Stamina = source.Stamina - 2;
            return (int)damage;
        }
        public override string GetName()
        {
            return "Magic Beam";
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
            source.Stamina = source.Stamina - 5;
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