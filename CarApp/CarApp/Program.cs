using System;
using CarApp.Entities;
using CarApp.Enums;




namespace CarApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var tesla = new ElectricCar("Nissan", "Leaf", 5, 220, Consumption.Econimic, EngineType.Electric, 100, 59 );

           
            tesla.PrintInfo();
            tesla.Drive(572);
            tesla.Recharge(2059);
            Console.ReadLine();

            var honda = new FuelCar("Honda", "Civic", 5, 210, Consumption.High, EngineType.Petrol, 60, 49);
            //{
            //    Brand = "Honda",
            //    Model = "Civic",
            //    Doors = 4,
            //    TopSpeed = 250,
            //    ConsumptionLevel = Consumption.Medium,
            //    Engine = EngineType.Petrol,
            //    FuelCapacity = 60,
            //    CurrentFuel = 51,

            //};
            honda.PrintInfo();
            honda.Drive(371);
            honda.Refuel(23);
            Console.ReadLine();
        }
    }
}
