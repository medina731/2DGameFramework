using Mandatory2DGameFramework.model.attack;
using Mandatory2DGameFramework.model.defence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.model.Cretures
{
    public class Elf : Creature
    {
        // Todo consider if elf should have some special attack or defence abilities
        public Elf()
        {
            Name = "Elf";
            HitPoint = 80;

            Attack = new AttackItem { Name = "Bow", Hit = 10, Range = 3 };
            Defence = new DefenceItem { Name = "Wings", ReduceHitPoint = 2 };
        }
    }
}
