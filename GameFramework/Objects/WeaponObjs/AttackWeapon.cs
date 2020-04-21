using GameFramework.Abstracts;
using GameFramework.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework.Objects.WeaponObjs
{
    public class AttackWeapon : AGear
    {
        public AttackWeapon(int damage, int defend, bool isUsed, int inventorySlot) 
        {
            Damage = damage;
            Defend = defend;
            InventorySlot = inventorySlot;
            IsUsed = isUsed;
        }

        public AttackWeapon()
        {

        }
        Random randomNum = new Random();


        
       public int WeaponDamage(TypeOfWeapons currentWeapon, Quality weaponQuality)
        {
            TypeOfWeapons[] weaponArr = new TypeOfWeapons[] { TypeOfWeapons.Sword, TypeOfWeapons.Spear, TypeOfWeapons.Axe};
            Quality[] qualityArr = new Quality[] { Quality.Wooden, Quality.Silver, Quality.Gold };
            // Wooden Quality
            if (weaponQuality == qualityArr[0])
            {
                // Sword can make damage from 5-15
                if (currentWeapon == weaponArr[0])
                {
                    Damage = randomNum.Next(0, 10);
                    return Damage;
                }

                // Spear can make damage from 1-30

                if (currentWeapon == weaponArr[1])
                {
                    Damage = randomNum.Next(0, 15);
                    return Damage;
                }
                // Axe can make damage from 1-30

                if (currentWeapon == weaponArr[2])
                {
                    Damage = randomNum.Next(0, 18);
                    return Damage;
                }
            }
            // Silver Quality
            if (weaponQuality == qualityArr[1])
            {
                // Sword can make damage from 5-15
                if (currentWeapon == weaponArr[0])
                {
                    Damage = randomNum.Next(0, 15);
                    return Damage;
                }

                // Spear can make damage from 1-30

                if (currentWeapon == weaponArr[1])
                {
                    Damage = randomNum.Next(0, 18);
                    return Damage;
                }
                // Axe can make damage from 1-30

                if (currentWeapon == weaponArr[2])
                {
                    Damage = randomNum.Next(0, 22);
                    return Damage;
                }
            }
            // Golden Quality
            if (weaponQuality == qualityArr[2])
            {
                // Sword can make damage from 5-15
                if (currentWeapon == weaponArr[0])
                {
                    Damage = randomNum.Next(9, 18);
                    return Damage;
                }

                // Spear can make damage from 1-30

                if (currentWeapon == weaponArr[1])
                {
                    Damage = randomNum.Next(12, 20);
                    return Damage;
                }
                // Axe can make damage from 1-30

                if (currentWeapon == weaponArr[2])
                {
                    Damage = randomNum.Next(14, 25);
                    return Damage;
                }
            }

            return Damage;
        }
      
    }
}
