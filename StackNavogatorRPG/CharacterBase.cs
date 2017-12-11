using System;
using System.Collections.Generic;

namespace StackNavogatorRPG
{

    /// <summary>
    /// Base class for any character.
    /// To be inherited by all other characters, be it player or enemy
    /// </summary>
    public abstract class CharacterBase
    {
        #region helpful functions
        public static int Clamp(int num, int low, int high)
        {
            return Math.Max(Math.Min(num, high), low);
        }
        static Random rng = new Random();
        public static int RandomInt
        {
            get { return rng.Next(); }
        }
        public static int RandomRange(int min, int max)
        {
            return rng.Next(min, max);
        }
        #endregion

        #region stats
        #region private
        int _health = 100;          //current health
        int _maxHealth = 100;       //maximum health
        int _stamina = 100;         //used for attacking
        int _maxStamina = 100;      //max stamina
        int _physicalAttack = 10;   //physical attack
        int _physicalDefense = 3;   //physical defense
        int _magicAttack = 20;      //magic defense
        int _magicDefense = 0;      //magic defense
        int _level = 0;
        int _experience = 0;
        int _experienceToNextLevel; //when this is reahced, the character levels up
        #endregion

        #region inventory
        public List<EquipableBase> Equipment;
        public List<ItemBase> Inventory;
        #endregion

        #region public
        public abstract string GetName();
        public int Health
        {
            get { return _health; }
            set { _health = Clamp(value, 0, 100); }
        }
        public int MaxHealth
        {
            get { return _maxHealth; }
            set { _maxHealth = Math.Max(value, 1); }
        }
        public int Stamina
        {
            get { return _stamina; }
            set { _stamina = Clamp(value, 0, _maxStamina); }
        }
        public int MaxStamina
        {
            get { return _maxStamina; }
            set { _maxStamina = value; }
        }
        public int PhysicalAttack
        {
            get{
                int atk = _physicalAttack;
                foreach (EquipableBase e in Equipment){
                    if (e != null)
                    {
                        atk += e.physicalAttackBoost;
                    }
                }
                return atk;
            }
            set{
                _physicalAttack = value;
            }
        }
        public int PhysicalDefense
        {
            get
            {
                int def = _physicalDefense;
                foreach (EquipableBase e in Equipment)
                {
                    if (e != null)
                    {
                        def += e.physicalDefenseBoost;
                    }
                }
                return def;
            }
            set
            {
                _physicalDefense = value;
            }
        }
        public int MagicAttack
        {
            get
            {
                int atk = _magicAttack;
                foreach (EquipableBase e in Equipment)
                {
                    if (e != null)
                    {
                        atk += e.MagicAttackBoost;
                    }
                }
                return atk;
            }
            set
            {
                _magicAttack = value;
            }
        }
        public int MagicDefense
        {
            get
            {
                int def = _magicDefense;
                foreach (EquipableBase e in Equipment)
                {
                    if (e != null)
                    {
                        def += e.MagicDefenseBoost;
                    }
                }
                return def;
            }
            set
            {
                _magicDefense = value;
            }
        }
        public int Level{
            get { return _level; }
        }
        public int Experience{
            get { return _experience; }
            set {
                _experience = value;
                while (_experience >= _experienceToNextLevel){
                    _experience -= _experienceToNextLevel;
                    LevelUp();
                }
            }
        }
        public int ExperienceToNextLevel{
            get { return Math.Max(1,_experienceToNextLevel); }
            set { _experienceToNextLevel = value; }
        }
        #endregion
        #endregion

        public CharacterBase()
        {
            Equipment = new List<EquipableBase>(6);
            Inventory = new List<ItemBase>();
        }

        public int Attack(AttackBase attack, CharacterBase target, out string message)
        {
            int damage = attack.Action(this, target, out message);
            return damage;
        }

        #region abstract methods
        abstract public void LevelUp();
        #endregion
    }
}
