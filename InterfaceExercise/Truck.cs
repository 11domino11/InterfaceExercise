using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public int numberOfWheels { get; set; } = 4;
        public int numberOfDoors { get; set; } = 4;
        public int numberOfPassengers { get; set; } = 4;
        public bool frontLicensePlate { get; set; } = false;
        public double bedLength { get; set; } = 5.5;
        public bool isDiesel { get; set; } = false;
        public string Logo { get; set; } = "Chevy";
        public string ManufactureDate { get; set; } = "8.19.00";
    }
}
