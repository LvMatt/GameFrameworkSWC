using GameFramework.Enum;
using GameFramework.Interfaces;
using GameFramework.Objects.WeaponObjs;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework.Abstracts
{
   public class AGear : IPosition
    {
        public int Damage { get; set; }
        public int Defend { get; set; }
        public bool IsUsed { get; set; }
        public int Quantity { get; set; }
        public int AddHealth { get; set; }
        public int InventorySlot { get; set; }
        public TypeOfWeapons AttackWeaponsType { get; set; }
        public TypeOfDefense DefenseWeaponsType { get; set; }

   
    }
}
