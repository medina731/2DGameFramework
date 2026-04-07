using Mandatory2DGameFramework.model.attack;
using Mandatory2DGameFramework.model.defence;
using Mandatory2DGameFramework.worlds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.model.Cretures
{
    public class CreatureLoot
    {
        private Creature creature;

        public CreatureLoot(Creature creature)
        {
            this.creature = creature;
        }

        public void Loot(WorldObject obj)
        {
            // Hvis objektet ikke kan lootes, gør ingenting
            if (!obj.Lootable)
                return;

            // Hvis det er et våben
            if (obj is AttackItem attack)
            {
                creature.Attack = attack;
            }

            // Hvis det er et forsvarsitem (defence)
            if (obj is DefenceItem defence)
            {
                creature.Defence = defence;
            }

            // Hvis objektet kan fjernes fra spilleverden
            if (obj.Removeable)
            {

            }

        }
    }
}
