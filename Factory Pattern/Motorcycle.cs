using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public class Motorcycle :IVehicle
    {
        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine($"Start doing wheelies!");
        }
    }
}
