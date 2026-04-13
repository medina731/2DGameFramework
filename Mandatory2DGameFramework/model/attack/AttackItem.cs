using Mandatory2DGameFramework.worlds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.model.attack
{
    public class AttackItem : WorldObject
    {
        public string Name { get; set; }
        public virtual int Hit { get; set; }
        public virtual int Range { get; set; }
        public virtual int Weight { get; set; } // tilføjet vægt property

        public AttackItem(string name, int hit, int range, int weight )
        {
            Name = string.Empty;
            Hit = hit;
            Range = range;
            Weight = weight;
            Lootable = true; // Attack items are lootable by default
        }

        public AttackItem() : this("", 0, 0, 0) // default constructor with default values
        { }

        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Hit)}={Hit}, {nameof(Range)}={Range},{nameof(Weight)}=}}";
        }
    }
}
