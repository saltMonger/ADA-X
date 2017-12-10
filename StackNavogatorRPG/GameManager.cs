using System;
using System.Collections.Generic;
using StackNavogatorRPG.Enemies;

namespace StackNavogatorRPG
{
    public class GameManager
    {
        static GameManager inst;
        public static GameManager Instance{
            get{
                if(inst == null){
                    inst = new GameManager();
                }
                return inst;
            }
        }

        GameManager(){
            playerCharacter = new PlayerCharacter();

            playerCharacter.PhysicalAttack = 5;
            playerCharacter.PhysicalDefense = 1;
            playerCharacter.MagicAttack = 1;
            playerCharacter.MagicDefense = 0;
            playerCharacter.MaxHealth = 20;
            playerCharacter.Health = 20;
            playerCharacter.MaxStamina = 10;
            playerCharacter.Stamina = 10;
            playerCharacter.ExperienceToNextLevel = 10;
            playerCharacter.Experience = 0;
        }

        //Game globals

        //Player
        public PlayerCharacter playerCharacter;

        //Enemies
        public List<EnemyCharacter> enemyList;
        public EnemyCharacter bossEnemy;

        public EnemyCharacter GetRandomEnemy(){
            return enemyList[0];
        }

        //Rooms

    }
}
