using System;
using CarApp.Enums;

namespace CarApp.Entities
{
    public class ElectricCar : Car
    {

        //## 2. Create class ElectricCar that inherits from Car. Should have:
        // * BatteryCapacity
        // * BatteryUsage(percentage of used battery)
        // * Drive - method that takes distance as parameter and calculates how much of
        //the battery has been used(distance* consumption(economic - 1, medium - 2, high - 3) / 10)
        // * Recharge(method that charges the battery of the car, it takes one parameter minutes,
        //10 minutes charges 1 percent of the battery)

        private int BatteryCapacity;
        private float BatteryUsage;
        

        public void Drive(float distance)
        {
            float driving = distance * (int)ConsumptionLevel / 10;

            if (BatteryUsage - driving < 0)
            {
                Console.WriteLine($"You have not enough battery, you can maximum pass {(BatteryUsage/(int)ConsumptionLevel) * 10 } km");
            }

            else
            {
                BatteryUsage = BatteryUsage - driving;
                Console.WriteLine($"you have passed the wanted distance, now you have {Convert.ToInt32(BatteryUsage)} % battery");
            }
        }
        public ElectricCar(string brand, string model, int doors, int speed, Consumption consumption, EngineType engine, int batcap, int batusage)
    : base(brand, model, doors, speed, consumption, engine)
        {
            BatteryCapacity = batcap;
            BatteryUsage = batusage;
        }

        public void Recharge(float minutes)
        {
            float charging = minutes / 10;

            if (charging > BatteryCapacity - BatteryUsage)
            {
                Console.WriteLine($"Maximum charging time is: {(BatteryCapacity - BatteryUsage) * 10} minutes");
            }
            else
            {
                BatteryUsage = BatteryUsage + charging; ;
                Console.WriteLine($"You have charged {Convert.ToInt32(charging)} %, now you have {Convert.ToInt32(BatteryUsage)} % battery");
            }
        }
        public ElectricCar()
        {

        }
    }
}
