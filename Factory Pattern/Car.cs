using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    class Car : IVehicle
    {
        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine( $"Drive way to fast, don't look where you are going!");
        }
    }
}
