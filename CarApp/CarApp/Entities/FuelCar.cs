using System;
using CarApp.Enums;

namespace CarApp.Entities
{
    public class FuelCar : Car
    {
        //## 3. Create class FuelCar that extends Car. Should have:
        //* FuelCapacity
        //* CurrentFuel(fuel in tank)
        //* Drive - method that takes distance as parameter and calculates how much fuel
        //has been used(distance* consumption(economic - 1, medium - 2, high - 3) / 10)
        //* Refuel(method that fills the tank with fuel, should take fuel as parameter
        //and shouldn't exceed fuel capacity)

        private int FuelCapacity;
        private float CurrentFuel;

        public void Drive(float distance)
        {
            float driving = distance * (int)ConsumptionLevel / 10;

            if (CurrentFuel - driving < 0)
            {
                Console.WriteLine($"You have not enough fuel, you can maximum pass {Convert.ToInt32((CurrentFuel / (int)ConsumptionLevel) * 10) } km");
            }

            else
            {
                CurrentFuel = CurrentFuel - driving;
                Console.WriteLine($"you have passed the wanted distance, now you have {Convert.ToInt32(CurrentFuel)} l of {Engine}");
            }
        }

        public void Refuel(float fuel)
        {
            if (fuel > FuelCapacity - CurrentFuel)
            {
                Console.WriteLine($"Maximum you can add is: {(FuelCapacity - CurrentFuel)} l of {Engine}");
            }
            else
            {
                CurrentFuel = CurrentFuel + fuel; ;
                Console.WriteLine($"You have charged {Convert.ToInt32(fuel)} %, now you have {Convert.ToInt32(CurrentFuel)} l of {Engine}");
            }
        }

        public FuelCar(string brand, string model, int doors, int speed, Consumption consumption, EngineType engine, int fuelcap, int fuelusage)
   : base(brand, model, doors, speed, consumption, engine)
        {
            FuelCapacity = fuelcap;
            CurrentFuel = fuelusage;
        }


        public FuelCar()
        {
        }
    }
}
