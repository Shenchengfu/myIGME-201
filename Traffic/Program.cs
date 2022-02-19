using System;
using Vehicles;

namespace Traffic
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.AddPassenger(new Compact());
            //program.AddPassenger(new FreightTrain());
        }

        //  Accepts any object with the IPassengerCarrier interface
        void AddPassenger(IPassengerCarrier vehicleObject)
        {
            vehicleObject.LoadPassenger();
            Console.WriteLine(vehicleObject.ToString());
        }
    }
}
