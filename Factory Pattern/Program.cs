using System;

namespace Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int wheelCount;
            bool input = false;
            do
            {
                Console.WriteLine("Enter the amount of wheels for the vehicle you want:");

                 input = int.TryParse(Console.ReadLine(), out wheelCount);
            }while(!input);

            var vehicle = VehicleFactory.GetVehicle(wheelCount);
            vehicle.Drive();
        }       
    }
}
