using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public int numberOfWheels { get; set; } = 4;
        public int numberOfDoors { get; set; } = 4;
        public int numberOfPassengers { get; set; } = 5;
        public bool frontLicensePlate { get; set; } = true;
        public double trunkSize { get; set; } = 4.5;
        public bool isElectric { get; set; } = false;
        public string Logo { get; set; } = "Ford";
        public string ManufactureDate { get; set; } = "1.2.22";
    }
}
