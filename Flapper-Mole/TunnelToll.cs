using System;

namespace TunnelToll
{
    public class TollBooth
    {
        private decimal TotalRevenue { get; set; }
        public decimal TollCLassA { get; private set; }
        public decimal TollClassB { get; private set; }
        public decimal TollClassC { get; private set; }
        public bool HGVAccepted { get; private set; }
        public bool IsOpen { get; set; }
        public bool BarrierRaised { get; set; }


        public TollBooth()
        {
            TollCLassA = 2.30m;
            TollClassB = 4.60m;
            TollClassC = 9.20m;
            HGVAccepted = false;
            IsOpen = true;
            BarrierRaised = false;
        }

        public TollBooth(bool hgv) : base()
        {
            HGVAccepted = hgv;
        }

        // Method to calculate toll based on vehicle class

        public void CalculateToll(string vehicleClass)
        {
            decimal tollAmount = 0m;
            switch (vehicleClass.ToUpper())
            {
                case "CAR":
                    tollAmount = TollCLassA;
                    break;
                case "BUS":
                    tollAmount = TollClassB;
                    break;
                case "HGV":
                    tollAmount = TollClassC;
                    break;
                case "BIKE":
                    tollAmount = 0m; 
                    break;
                default:
                    Console.WriteLine("Invalid vehicle class.");
                    return;
            }
            TotalRevenue += tollAmount;
            Console.WriteLine($"Toll for class {vehicleClass}: {tollAmount:C}. Total revenue: {TotalRevenue:C}");
        }







    }
}
