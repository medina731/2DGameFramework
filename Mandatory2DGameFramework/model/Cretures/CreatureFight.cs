//using System;
using Mandatory2DGameFramework.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.model.Cretures
{
    public class CreatureFight : IFightable
    {

        private Creature creature;

        public CreatureFight(Creature creature)
        {
            this.creature = creature;
        }

        public int Hit()
        {
            return 1;
        }

        public void ReceiveHit(int hit)
        {
            creature.ApplyDamage(hit);
        }

    }
}
