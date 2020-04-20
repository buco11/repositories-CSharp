using System;
using CarApp.Entities;
using CarApp.Enums;

namespace CarApp.Entities
{
    public class Car
    {
        //  ## 1. Create class Car. The Car should have:
        //* Id(randomly generated)
        //* Brand
        //* Model
        //* Doors
        //* TopSpeed
        //* Consumption(economic, medium, high) - **enum**
        //* EngineType(petrol, diesel, electric) - **enum**
        //* PrintInfo(method that prints info about the car)
        static int counter = 0;
        

        public int CarId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Doors { get; set; }
        public int TopSpeed { get; set; }
        public Consumption ConsumptionLevel { get; set; }
        public EngineType Engine { get; set; }
        

        public void PrintInfo()
        {
            Console.WriteLine($" Brand of the car is {Brand}, model: {Model}, with {Doors} " +
                $"doors, and top speed at: {TopSpeed}km/h, with {ConsumptionLevel} level" +
                $" of consumption and {Engine} engine ");
        }

        public Car(string brand, string model, int doors, int speed, Consumption consumption, EngineType engine)
        {
            counter += 1;
            CarId = counter;
            Brand = brand;
            Model = model;
            Doors = doors;
            TopSpeed = speed;
            ConsumptionLevel = consumption;
            Engine = engine;
        }
        public Car()
        {

        }
      
    }
}