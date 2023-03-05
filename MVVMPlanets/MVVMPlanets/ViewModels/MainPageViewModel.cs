using MVVMPlanets.Models;
using MVVMPlanets.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMPlanets.ViewModels
{
    public class MainPageViewModel : BasePageViewModel
    {
        public string LearnMore { get; set; }

        public string URL { get; set; }

        private IPlanetService _planetService;

        private IStarService _starService;

        public MainPageViewModel()
        {
            _planetService = new PlanetService();
            var planets = _planetService.GetThePlanets();
            SessionInfo.Instance.PlanetsAndStars.AddRange(planets);

            _starService = new StarService();
            var stars = _starService.GetTheStars();
            SessionInfo.Instance.PlanetsAndStars.AddRange(stars);
        }
    }
}
