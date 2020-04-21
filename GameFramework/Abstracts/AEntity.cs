using GameFramework.Enum;
using GameFramework.Interfaces;
using GameFramework.Objects;
using GameFramework.Objects.WeaponObjs;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework.Abstracts
{
    public abstract class AEntity : IPosition
    {
        protected static int id = 0;
        int currentHp;
        public int EntityPosX { get; set; } 
        public int EntityPosY { get; set; }
        public AGear Gear { get; set; }
        public State EntityState { get; set; }
        public AEntity entity { get; set; }
        public Potion HealthPotion { get; set; }
        public AttackWeapon CurrentWeapon { get; set; }
        // public List<AGear> Inventory { get; set; }
        public IDictionary<int, AGear> Inventory = new Dictionary<int, AGear>();

        public int Id { get; set; }
        public int _hp { get; set; }
        public bool isEntityDead { get; set; }
        public int Hp
        {
            get => _hp;
            set
            {
                if (_hp <= 0)
                {
                    isEntityDead = true;
                    if (isEntityDead)
                    {
                        Dead();
                    }
                }
                _hp = value;
            }
        }
        public AEntity(int id, int hp, int entityPosX, int entityPosY)
        {
            Id = id;
            Hp = hp;
            EntityState = State.Alive;
            EntityPosX = entityPosX;
            EntityPosY = entityPosY;

        }

        public void Dead()
        {
            EntityPosX = 1; EntityPosY = 1; Hp = 100;
            Inventory = null;
        }

    
    }
}
