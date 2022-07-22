using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public int numberOfWheels { get; set; } = 4;
        public int numberOfDoors { get; set; } = 4;
        public int numberOfPassengers { get; set; } = 8;
        public bool frontLicensePlate { get; set; } = true;
        public bool layDownSeats { get; set; } = true;
        public double cargoSize { get; set; } = 8.0;
        public string Logo { get; set; } = "Honda";
        public string ManufactureDate { get; set; } = "12.25.98";
    }
}
