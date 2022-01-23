using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Models
{
    internal class MonsterTruck : Car
    {
        public int TireSize { get; set; }
        private string _name = "monster truck";
        
        public void Jump()
        {
            Console.WriteLine($"You jump the ramp in the {_name}.");
        }
    }
}
