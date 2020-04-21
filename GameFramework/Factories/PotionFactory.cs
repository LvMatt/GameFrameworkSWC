using GameFramework.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework.Factories
{
    public static class PotionFactory
    {
        public static Potion MakePotion(int quantity)
        {
            Potion potion = new Potion(quantity);
            return potion;
        }
    }
}
