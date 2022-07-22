using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Car car = new Car();
            SUV suv = new SUV();
            Truck truck = new Truck();

            Console.WriteLine($"The default information for car is: Logo {car.Logo}: Date {car.ManufactureDate}: Trunk Size {car.trunkSize} please visit our website for more information");
            Console.WriteLine($"The default information for truck is: Logo {truck.Logo}: Date {truck.ManufactureDate}: Bed Length {truck.bedLength} please visit our website for more information");
            Console.WriteLine($"The default information for SUV is: Logo {suv.Logo}: Date {suv.ManufactureDate}: Cargo Size {suv.cargoSize} please visit our website for more information");
            Console.ReadLine();
        }
    }
}
