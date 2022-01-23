using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Models
{
    internal class NissanLeaf : Car
    {
        public bool isElectric = true;
        private string _name = "Nissan Leaf";

        public void Charge()
        {
            Console.WriteLine($"You charge the {_name}.");
        }
    }
}
