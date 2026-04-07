using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.model.Cretures
{
    public class Siren : Creature
    {

        // Todo consider if siren should have some special attack or defence abilities
        public Siren()
        {
            Name = "Siren";
            HitPoint = 140;


          Attack = new attack.AttackItem { Name = "Siren Song", Hit = 20, Range = 4 };
          Defence = new defence.DefenceItem { Name = "Siren's Call", ReduceHitPoint = 10 };
        }

    }
}
