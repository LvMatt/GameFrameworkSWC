using GameFramework.Enum;
using GameFramework.Objects.WeaponObjs;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework.Factories
{

    public static class AttackWeaponFactory
    {
        public static AttackWeapon MakeAttackWeapon(int damage, int defend, bool isUsed, int inventorySlot, TypeOfWeapons weapon)
        {
            AttackWeapon attack = new AttackWeapon(damage, defend, isUsed, inventorySlot);
            return attack;
        }
    }
}
