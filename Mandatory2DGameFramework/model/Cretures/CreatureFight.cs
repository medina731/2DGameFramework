//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.model.Cretures
{
    public class CreatureFight 
    {

        private Creature creature;

        public CreatureFight(Creature creature)
        {
            this.creature = creature;
        }

        public int Hit()
        {
            if (creature.Attack == null)
                return 1;

            return creature.Attack.Hit;
        }

        public void ReceiveHit(int hit)
        {
            int reducedHit = hit;

            if (creature.Defence != null)
                reducedHit -= hit - creature.Defence.ReduceHitPoint;

            if (reducedHit < 0)
                reducedHit = 0;

            creature.HitPoint -= reducedHit;

            if (creature.HitPoint < 0)
                creature.HitPoint = 0;



        }
    }
}
