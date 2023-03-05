using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMPlanets.Models
{
    public class CelestialObject
    {
        public string Name { get; set; }

        public string ImageURL { get; set; }

        public bool IsPlanet { get; set; }

        public bool IsStar => !IsPlanet;


        public CelestialObject() { }
    }

    public class Root
    {
        public List<Planet> planets { get; set; }

        public List<Star> stars { get; set; }
    }
}
