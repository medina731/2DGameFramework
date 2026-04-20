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
            return creature.Attack?.Hit ?? 0; // return the hit value of the creature's attack, or 0 if it has no attack
        }

        public void ReceiveHit(int hit)
        {
            int defence = creature.Defence?.DefenceValue ?? 0; // get the defence value of the creature's defence, or 0 if it has no defence

            int damage = Math.Max(hit - defence, 0); // calculate the damage after applying defence, ensuring it doesn't go below 0
            creature.ApplyDamage(damage); // apply the calculated damage to the creature
        }

    }
}
