using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.model.attack
{
    public class AttackItemComposite : AttackItem
    {
        private List<AttackItem> items = new();

        public AttackItemComposite(string name)
            :base(name, 0, 0, 0) // default values for hit, range, and weight
        { }

        public void Add(AttackItem item)
        {
            items.Add(item);
        }



        public override int Hit => items.Sum(i => i.Hit); // override hit to return the sum of hits from all contained items
        public override int Weight => items.Sum(i => i.Weight); // override weight to return the sum of weights from all contained items
        public override int Range => items.Max(i => i.Range); // override range to return the maximum range from all contained items
    }
}
