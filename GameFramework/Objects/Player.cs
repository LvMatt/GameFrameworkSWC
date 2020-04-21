using GameFramework.Abstracts;
using GameFramework.Enum;
using GameFramework.Objects;
using GameFramework.Objects.WeaponObjs;
using System;
using System.Collections.Generic;
using System.Text;


namespace GameFramework.Characters
{
    public class Player : AEntity
    {
        public Player(int id, int hp, int currentHp, int entityPosX, int entityPosY,  AttackWeapon attWeapon, Potion healthPotion) : base(id, hp, entityPosX, entityPosY)
        {
            CurrentWeapon = new AttackWeapon();
            HealthPotion = healthPotion;
            EntityState = State.Alive; 
            entityPosX = 1;
            entityPosY = 1;
            hp = 100;
        }

            
        public void PlayerAttack(TypeOfWeapons currentWeapon, Quality weaponQuality)
        {
          while(EntityState != State.Dead)
            {
                if(CurrentWeapon.WeaponDamage(currentWeapon, weaponQuality) < GetDamageHp())
                {
                    GetDamageHp();
                }
            }
              if (Hp <= 0)
                {
                    EntityState = State.Dead;
                    entity.Dead();
                }
        }

   

        public int GetDamageHp()
        {
            if (Gear.Damage > Gear.Defend)
            {
                Hp = entity.Hp - Gear.Damage + Gear.Defend;
                return Hp;
            }
            else return Hp;
           
        }

        public void AddToInventory(int inventorySlot, AGear gear)
        {
            if(Inventory != null)
            {
                Inventory.Add(inventorySlot, gear);
            }
        }
       

        public int AddHealth()
        {
            if(Hp < 100)
            {
                int maxPlayerHP = 100;
                Hp = Hp + HealthPotion.AddHealth;
                if (Hp > maxPlayerHP) Hp = 100;
                else throw new Exception("Health cannot be more than 100");
            }
            return Hp;
        }

        public bool PlayerMovements(Direction newDirect)
        {

            int newPosX = EntityPosX;
            int newPosY = EntityPosY;

            switch (newDirect)
            {
                case Direction.Up:
                    newPosX--;
                    break;
                case Direction.Left:
                    newPosY++;
                    break;
                case Direction.Down:
                    newPosX++;
                    break;
                case Direction.Right:
                    newPosX--;
                    break;
            }

            EntityPosX = newPosX;
            EntityPosY = newPosY;

            return true;

        }


     

    }
}
        
