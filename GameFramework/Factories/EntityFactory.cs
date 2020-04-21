using GameFramework.Abstracts;
using GameFramework.Characters;
using GameFramework.Enum;
using GameFramework.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework.Factories
{
   public static class EntityFactory 
    {
        public  static Enemy MakeEntity(int id, int hp, int positionX, int positionY, EnemyType enemy)
        {
            Enemy entity = new Enemy(id, hp, positionX, positionY );
            return entity;
        }
    }
}
