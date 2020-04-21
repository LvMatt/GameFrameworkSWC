using GameFramework.Abstracts;
using GameFramework.Characters;
using GameFramework.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework.Objects
{
    public class Enemy : AEntity
    {
        public Enemy(int id, int hp, int entityPosX, int entityPosY) : base(id, hp, entityPosX, entityPosY)
        {
            EntityState = State.Alive;
        }
        Random randomNum = new Random();


        public void EnemyAttack(Player player)
        {
            if(EntityState == State.Alive && player.Hp < 100) 
            {
                player.GetDamageHp();
            }
        }


        public bool EnemyMovements(World world)
        {
            int newPosX = EntityPosX;
            int newPosY = EntityPosY;

            if (randomNum.Next(1, 5) == 1) 
            {
                newPosX--;
            }
           else if (randomNum.Next(1, 5) == 2) 
            {
                newPosX++;
            }
           else if (randomNum.Next(1, 5) == 3) 
            {
                newPosY--;
            }
            else if (randomNum.Next(1, 5) == 4) 
            {
                newPosY++;
            }


            EntityPosX = newPosX;
            EntityPosY = newPosY;

            return true;

        }
    }
}
