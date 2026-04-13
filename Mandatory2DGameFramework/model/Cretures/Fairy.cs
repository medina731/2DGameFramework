using Mandatory2DGameFramework.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.model.Cretures
{
    public class Fairy : Creature
    {
        // Todo consider if fairy should have some special attack or defence abilities
        public Fairy(string name) : base(name, 100)
        {
            MovementStrategy = new WalkStrategy();
        }



        protected override void DecideAction()
        {
            Console.WriteLine($"{Name} decides whether to heal or hide.");
        }

        protected override void ExecuteAction()
        {
            Console.WriteLine($"{Name} sprinkles magical healing dust.");
        }




    }
}
