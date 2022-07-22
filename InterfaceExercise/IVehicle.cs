using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int numberOfWheels { get; set; }
        public int numberOfDoors { get; set; }
        public int numberOfPassengers { get; set; }
        public bool frontLicensePlate { get; set; }

    }
}
