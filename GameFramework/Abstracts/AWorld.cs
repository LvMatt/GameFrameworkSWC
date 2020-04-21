using GameFramework.Characters;
using System;
using System.Collections.Generic;
using System.Text;
using GameFramework.Enum;
using GameFramework.Interfaces;

namespace GameFramework.Abstracts
{
    public abstract class  AWorld : IPosition
    {
        public AEntity Character { get; set; }
        public AGear Gear { get; set; }
        public List<AEntity> Entities { get; set; }
        public List<AGear> AttackGears { get; set; }
        public List<AGear> DefenseGears { get; set; }
        public List<AGear> Potions { get; set; }
        public int SizeX { get; set; }
        public int SizeY { get; set; }
        public int RandSizeX { get ; set ; }
        public int RandSizeY { get; set; }

    }
}
