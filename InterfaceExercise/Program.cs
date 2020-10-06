using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE - Create 2 Interfaces called IVehicle & ICompany



            //DONE - Create 3 classes called Car , Truck , & SUV

            //DONE - In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //DONE - In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*DONE - Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * DONE - Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            // DONE - Now, create objects of your 3 classes and give their members values;
            Car myFirstCar = new Car { CompanyLogo = "Toyota", CompanyName = "Toyota", HasFogLights = false, HasHorn = true, HasTrunk = true, HeightFromGround = 19, NumberOfDoors = 4, NumberOfWheels = 4 };
            Truck myFirstTruck = new Truck { NumberOfWheels = 4, BedSize = 6, NumberOfDoors = 2, HasHorn = true, CompanyLogo = "honda", CompanyName = "honda", HasFogLights = true, IsLifted = true };
            SUV myFirstSUV = new SUV { HasFogLights = false, CompanyName = "Audi", CompanyLogo = "audi symbol", HasHorn = true, NumberOfDoors = 4, HasTrunkCover = true, NumberOfWheels = 4, TrunkHeight = 35 };


            //Creatively display and organize their values
            List<IVehicle> vehicles = new List<IVehicle>();

            vehicles.Add(myFirstSUV);
            vehicles.Add(myFirstTruck);
            vehicles.Add(myFirstCar);

            foreach (IVehicle vehicle in vehicles)
            {
                vehicle.Drive();
                Console.WriteLine($"Number of Doors: {vehicle.NumberOfDoors}, Number of Wheels: {vehicle.NumberOfWheels}, Has Horn: {vehicle.HasHorn}, Has Fog Lights: {vehicle.HasFogLights}");
                Console.WriteLine();

            }
            
        }
    }
}
