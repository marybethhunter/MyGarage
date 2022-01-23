using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Models
{
    internal class HotAirBalloon : Aircraft
    {
        public int BalloonSize { get; set; }
        private string _name = "hot air balloon";
        public string Design { get; set; }


        public void AirUp()
        {
            Console.WriteLine($"You light the flame and inflate the {_name}.");
        }
        
    }
}
