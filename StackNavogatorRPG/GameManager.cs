using System;
using System.Collections.Generic;
using StackNavogatorRPG.Enemies;
using StackNavogatorRPG.Map;
using UIKit;

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

            //init enemies
            enemyList = new List<EnemyCharacter>();
            enemyList.Add(new Enemy_Goblin());
            enemyList.Add(new Enemy_Gargoyle());
            enemyList.Add(new Enemy_Hamadryid());
            enemyList.Add(new Enemy_Rat());
        }

        //Game globals

        //Player
        public PlayerCharacter playerCharacter;

        //Enemies
        public List<EnemyCharacter> enemyList;
        public EnemyCharacter bossEnemy = new Enemy_FinalBoss();

        static Random r = new Random();

        public EnemyCharacter GetRandomEnemy(){
            int index = r.Next(0, enemyList.Count);
            EnemyCharacter c = enemyList[index];
            c.Reset();
            return c;
        }

        public EnemyCharacter GetBossEnemy()
        {
            EnemyCharacter c = new Enemy_FinalBoss();
            return c;
        }

        public void RestartGame()
        {
            playerCharacter.PhysicalAttack = 5;
            playerCharacter.PhysicalDefense = 1;
            playerCharacter.MagicAttack = 1;
            playerCharacter.MagicDefense = 0;
            playerCharacter.MaxHealth = 20;
            playerCharacter.Health = 20;
            playerCharacter.MaxStamina = 10;
            playerCharacter.Stamina = 10;
            playerCharacter.ExperienceToNextLevel = 10;
            playerCharacter.Level = 0;
            playerCharacter.UpdateStats();

            playerCharacter.equipment.Clear();
            playerCharacter.bag.Clear();

        }

        //Rooms

    }
}
