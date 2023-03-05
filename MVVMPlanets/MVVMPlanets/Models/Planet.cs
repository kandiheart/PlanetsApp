using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMPlanets.Models
{
    public class Planet : CelestialObject
    {
        public string Source { get; set; }

        public int Year { get; set; }

        public Planet() {
            IsPlanet = true;
        }
    }
}
