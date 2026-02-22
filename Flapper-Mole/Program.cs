using System;
using TrafficGenerator;
using TunnelToll;

/*
 Todo:
 * toll booth method
 * ^ calculate toll based on vehicle type and fast pass status
 */

class Program
{
    static void Main(string[] args)
    {
        //test code to generate traffic and calculate tolls
        TollBooth tollBooth = new TollBooth();
        Vehicle[] vehicles = TrafficMaker.Traffic(10);
        foreach (var vehicle in vehicles)
        {
            string vehicleType = vehicle.GetType().Name;
            tollBooth.CalculateToll(vehicleType);
        }

        Console.ReadLine();
    }
}
    

