using MVVMPlanets.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MVVMPlanets.ViewModels
{
    public class CelestialObjectViewModel : BasePageViewModel
    {
        public List<Planet> Planets => SessionInfo.Instance.Planets;

        public List<Star> Stars => SessionInfo.Instance.Stars;

        public CelestialObjectViewModel() {}
    }
}
