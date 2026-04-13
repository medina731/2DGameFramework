using Mandatory2DGameFramework.Interfaces;
using Mandatory2DGameFramework.model.attack;
using Mandatory2DGameFramework.model.defence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mandatory2DGameFramework.Strategy;

namespace Mandatory2DGameFramework.model.Cretures
{
    public class Elf : Creature
    {
        // Todo consider if elf should have some special attack or defence abilities
        public Elf(string name) : base(name,80)
        {
            MovementStrategy = new WalkStrategy();
        }
       
           
        protected override void Move()
        {
            Console.WriteLine($"{Name} moves swiftly through the forest.");
        }

        protected override void DecideAction()
        {
            Console.WriteLine($"{Name} looks around for threats.");
        }

        protected override void ExecuteAction()
        {
            Console.WriteLine($"{Name} prepares to shoot an arrow.");
        }
        //Attack = new AttackItem { Name = "Bow", Hit = 10, Range = 3 };
         
        //    Defence = new DefenceItem { Name = "Wings", ReduceHitPoint = 2 };
        }
    }

