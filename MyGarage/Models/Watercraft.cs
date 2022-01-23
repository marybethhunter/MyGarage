using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Models
{
    internal class Watercraft : VehicleBase
    {
        public void Drive()
        {
            Console.WriteLine("You drive the watercraft.");
        }
    }
}
