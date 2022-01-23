using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Models
{
    internal class VehicleBase
    {
        //Refactor your Car, Aircraft, and Watercraft classes to all inherit from a common Vehicle class that contains all the shared properties and/or methods

        public int fuelCapacity { get; set; }
        public string Color { get; set; }
        public int passengerOccupancy { get; set; }

        public void Refuel()
        {
            Console.WriteLine("You have refueled the vehicle.");
        }


    }
}
