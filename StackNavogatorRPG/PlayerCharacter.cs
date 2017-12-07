using System;
using System.Collections.Generic;
namespace StackNavogatorRPG
{
    public class PlayerCharacter : CharacterBase
    {
        public List<AttackBase> attacks = new List<AttackBase>();

        public PlayerCharacter()
        {
            //test
            attacks.Add(new Attack_Punch());
            attacks.Add(new Attack_Magic());
            attacks.Add(new Attack_Healing());
        }

        public override void LevelUp()
        {
            //increase stats
        }

        public override string GetName()
        {
            return "You";
        }
    }
}
