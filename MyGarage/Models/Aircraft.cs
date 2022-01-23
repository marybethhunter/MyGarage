using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Models
{
    internal class Aircraft : VehicleBase
    {
        public void Land()
        {
            Console.WriteLine("You land the aircraft.");
        }

        public void Fly()
        {
            Console.WriteLine("You start flying the aircraft.");
        }
    }
}
