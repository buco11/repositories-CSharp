using System;
using CarApp.Entities;
using CarApp.Enums;




namespace CarApp
{
    class Program
    {
        static void Main(string[] args)
        {

            ElectricCar nissan = new ElectricCar("Nissan", "Leaf", 5, 220, Consumption.Econimic, EngineType.Electric, 100, 59);

           
            nissan.PrintInfo();
            nissan.Drive(572);
            nissan.Recharge(2059);
            Console.ReadLine();

            FuelCar honda = new FuelCar("Honda", "Civic - Type R", 4, 230, Consumption.Medium, EngineType.Petrol, 60, 49);
           
            honda.PrintInfo();
            honda.Drive(195);
            honda.Refuel(9);
            Console.ReadLine();
        }
    }
}
