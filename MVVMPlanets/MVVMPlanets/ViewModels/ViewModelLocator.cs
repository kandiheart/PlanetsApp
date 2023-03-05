using CommonServiceLocator;

namespace MVVMPlanets.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            Bootstrap.Initialize();
        }

        public MainPageViewModel MainVM 
        { 
            get 
            { 
                return ServiceLocator.Current.GetInstance<MainPageViewModel>(); 
            } 
        }

        public CelestialObjectViewModel CelestialVM 
        { 
            get 
            { 
                return ServiceLocator.Current.GetInstance<CelestialObjectViewModel>(); 
            } 
        }
    }
}
