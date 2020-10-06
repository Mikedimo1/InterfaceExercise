using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : ICompany, IVehicle
    {
    public int TrunkHeight { get; set; }
    public bool HasTrunkCover { get; set; }

    //ICompany
    public string CompanyName { get; set; }
    public string CompanyLogo { get; set; }

    //IVehicle
    public int NumberOfWheels { get; set; }
    public int NumberOfDoors { get; set; }
    public bool HasHorn { get; set; }
    public bool HasFogLights { get; set; }
       
    }
}

