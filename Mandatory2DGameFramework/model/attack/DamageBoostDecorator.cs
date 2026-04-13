using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.model.attack
{
    public class DamageBoostDecorator : AttackItemDecorator
    {
        private int bonus; 

        public DamageBoostDecorator(AttackItem inner, int bonus) : base(inner)
        {
            this.bonus = bonus;
        }

        public override int Hit => inner.Hit + bonus; // override hit to return the base hit plus the bonus
    }
}
