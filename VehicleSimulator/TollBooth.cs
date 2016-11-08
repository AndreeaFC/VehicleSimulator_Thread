using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VehicleSimulator
{
    class TollBooth
    {
        public TollBooth()
        {
            mMutex = new Mutex();
        }

        public void AcceptPayment(Vehicle vehicle)
        {
            mMutex.WaitOne();
            vehicle.PayToll();
            mMutex.ReleaseMutex();
        }

        private Mutex mMutex;
        
    }
}
