using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Models
{
    internal class Car : VehicleBase
    {
        public int batteryCapacityInAmps { get; set; }

        public void Drive()
        {
            Console.WriteLine("You accelarate and begin driving.");
        }

        public void Brake()
        {
            Console.WriteLine($"You started to brake.");
        }
    }
}
