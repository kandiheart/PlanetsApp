using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMPlanets.Models
{
    public class Star : CelestialObject
    {
        public string Distance { get; set; }

        public decimal Magnitude { get; set; }

        public Star()
        {
            IsPlanet = false;
        }
    }
}
