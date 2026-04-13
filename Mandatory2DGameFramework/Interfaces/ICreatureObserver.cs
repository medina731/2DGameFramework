using Mandatory2DGameFramework.model.Cretures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.Interfaces
{
    public interface ICreatureObserver
    {
        public void OnCreatureHit(Creature creature, int hit);
         public void OnCreatureDeath(Creature creature);
    }
}
