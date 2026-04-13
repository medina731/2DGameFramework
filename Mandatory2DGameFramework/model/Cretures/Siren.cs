using Mandatory2DGameFramework.Strategy;
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
        public Siren(string name) : base(name, 140)
        { 
        MovementStrategy = new WalkStrategy();
        }

        
        protected override void DecideAction()
        {
            Console.WriteLine($"{Name} listens for nearby creatures.");
        }

        protected override void ExecuteAction()
        {
            Console.WriteLine($"{Name} sings a hypnotic melody.");
        }

    }
}
