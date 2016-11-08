using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VehicleSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numThreads = 5;
            TollBooth tollBooth = new TollBooth();
            Thread[] threads = new Thread[numThreads];
            for (int i = 0; i < numThreads; i++)
            {
                Vehicle vehicle = new Vehicle(i);
                threads[i] = new Thread(() => vehicle.Drive(tollBooth));
            }

            foreach (var thread in threads)
            {
                thread.Start();
            }

            foreach (var thread in threads)
            {
                thread.Join();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
