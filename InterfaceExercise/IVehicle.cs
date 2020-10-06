using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public bool HasHorn { get; set; }
        public bool HasFogLights { get; set; }
        public void Drive()
        {
            Console.WriteLine($"Driving in my {GetType().Name}");
        }
    }
}
