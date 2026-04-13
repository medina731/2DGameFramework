using Mandatory2DGameFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.Strategy
{
    public class WalkStrategy : IMovementStrategy
    {
        public void Move(string creatureName)
        {
            Console.WriteLine($"{creatureName} walks slowly across the ground.");
        }
    }
}
