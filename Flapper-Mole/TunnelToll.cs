using System;

namespace TunnelToll
{
    public class TollBooth
    {
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





        
    }
}
