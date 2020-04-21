using GameFramework.Enum;
using GameFramework.Objects.WeaponObjs;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework.Factories
{
   public static class DefenseWeaponFactory
    {
        public static DefenseWeapon MakeDefenseWeapon(int damage, int defend, bool isUsed, int inventorySlot, TypeOfDefense defense)
        {
            DefenseWeapon _defense = new DefenseWeapon(damage, defend, isUsed, inventorySlot);
            return _defense;
        }
    }
}
