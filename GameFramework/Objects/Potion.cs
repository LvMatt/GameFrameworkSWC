using GameFramework.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework.Objects
{
   public class Potion : AGear
    {
        public Potion(int quantity)
        {
            AddHealth = 20;
            Quantity = quantity;
        }
    }
}
