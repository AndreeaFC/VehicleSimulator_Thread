using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSimulator
{
    class Vehicle
    {
        public Vehicle(int id)
        {
            mId = id;
        }

        public void PayToll()
        {
            Console.WriteLine("Vehicle {0} paid bridge toll", mId);
        }
        
        public void Drive(TollBooth tollBooth)
        {
            StartJourney();
            DriveToTollBooth();
            RunIntoTollBooth(tollBooth);
            ExitTollBooth();
            CrossBridge();
        }

        private void StartJourney()
        {
            Console.WriteLine("Vehicle {0} starts journey", mId);
        }

        private void DriveToTollBooth()
        {
            Console.WriteLine("Vehicle {0} drives to toll booth", mId);
        }

        private void RunIntoTollBooth(TollBooth tollBooth)
        {
            tollBooth.AcceptPayment(this);
        }

        private void ExitTollBooth()
        {
            Console.WriteLine("Vehicle {0} exits toll booth", mId);
        }

        private void CrossBridge()
        {
            Console.WriteLine("Vehicle {0} crossed the bridge", mId);
        }

        private int mId;
    }
}
