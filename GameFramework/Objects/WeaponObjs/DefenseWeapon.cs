using GameFramework.Abstracts;
using GameFramework.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework.Objects.WeaponObjs
{
   public class DefenseWeapon : AGear
    {
        public DefenseWeapon(int damage, int defend, bool isUsed, int inventorySlot)
        {
            Damage = damage;
            Defend = defend;
            IsUsed = isUsed;
            InventorySlot = inventorySlot;
        }
       public Random randomNum = new Random();


        public int WeaponDefense(TypeOfDefense currentWeapon)
        {
            TypeOfDefense[] weaponArr = new TypeOfDefense[] { TypeOfDefense.Shoes, TypeOfDefense.Shield, TypeOfDefense.Helmet };
            // Wooden Quality
            // Sword can make damage from 5-15
            if (currentWeapon == weaponArr[0])
            {
                Defend = randomNum.Next(0, 10);
                return Defend;
            }
            if (currentWeapon == weaponArr[1])
            {
                Defend = randomNum.Next(0, 15);
                return Defend;
            }
            if (currentWeapon == weaponArr[2])
            {
                Defend = randomNum.Next(5, 15);
                return Defend;
            }
            return Defend;

        }

     }
}
