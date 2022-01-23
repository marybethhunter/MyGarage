using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Models
{
    internal class Submarine : Watercraft
    {
        private string _name = "submarine";
        public bool IsUnderwater = true;

        public void Resurface()
        {
            Console.WriteLine($"You bring the {_name} to the surface of the water.");
        }
    }
}
