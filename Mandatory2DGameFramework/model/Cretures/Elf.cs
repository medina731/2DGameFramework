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
        }
    }
}
