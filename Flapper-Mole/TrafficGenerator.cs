using System;

namespace TrafficGenerator
{
    public abstract class Vehicle
    {
        public string LicensePlate { get; private set; }
        public bool FastPass { get; private set; }

        public Vehicle(bool fastPass)
        {
            GenerateLicensePlate();
            FastPass = fastPass;
        }

        internal void GenerateLicensePlate()
        {
            LicensePlate = Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
        }
    }

    public class Car : Vehicle
    {
        public Car(bool fastPass) : base(fastPass)
        {
        }
    }

    public class HGV : Vehicle
    {
        public HGV(bool fastPass) : base(fastPass)
        {
        }
    }

    public class Bike : Vehicle
    {
        public Bike(bool fastPass) : base(fastPass)
        {
        }
    }

    public class Bus : Vehicle
    {
        public Bus(bool fastPass) : base(fastPass)
        {
        }
    }

    
    public static class TrafficMaker
    {
        public static Vehicle[] Traffic(int numberOfVehicles)
        {
            Vehicle[] vehicles = new Vehicle[numberOfVehicles];
            Random random = new Random();
            for (int i = 0; i < numberOfVehicles; i++)
            {
                int vehicleType = random.Next(4);
                bool fastPass = random.Next(3) == 0; // 25% chance fastpass
                switch (vehicleType)
                {
                    case 0:
                        vehicles[i] = new Car(fastPass);
                        break;
                    case 1:
                        vehicles[i] = new HGV(fastPass);
                        break;
                    case 2:
                        vehicles[i] = new Bike(fastPass);
                        break;
                    case 3:
                        vehicles[i] = new Bus(fastPass);
                        break;
                }
            }
            return vehicles;
        }
    }
}