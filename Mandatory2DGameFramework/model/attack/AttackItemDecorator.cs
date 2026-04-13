using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.model.attack
{
    public abstract class AttackItemDecorator : AttackItem
    {
        protected AttackItem inner;

        protected AttackItemDecorator(AttackItem inner) 
        :base(inner.Name, inner.Hit, inner.Range,inner.Weight)
        {
            this.inner = inner;
        }
    }
}
