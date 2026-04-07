using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.model.Cretures
{
    public class Fairy : Creature
    {
        // Todo consider if fairy should have some special attack or defence abilities
        public Fairy()
        {
            Name = "Fairy";
            HitPoint = 100;

            Attack = new attack.AttackItem { Name = "Magic Wand", Hit = 15, Range = 2 };
            Defence = new defence.DefenceItem { Name = "Magic Shield", ReduceHitPoint = 5 };
        }

    }
}
