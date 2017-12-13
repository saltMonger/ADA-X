using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace StackNavogatorRPG
{
    public abstract class EnemyCharacter : CharacterBase
    {
        public List<AttackBase> attacks = new List<AttackBase>();

        public EnemyCharacter()
        {

        }

        public virtual AttackBase GetRandomAttack()
        {
            Random r = new Random();
            return attacks[r.Next(0, attacks.Count)];
        }

        public override void LevelUp()
        {
            //Enemies cannot level up
        }

        public abstract UIImage GetImage();

        public abstract int GetExpValue();
    }
}

