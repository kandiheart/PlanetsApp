using MVVMPlanets.Models;
using MVVMPlanets.Services;
using MVVMPlanets.ViewModels;

namespace MVVMPlanets.Views;

public partial class CelestialObjectPage : ContentPage, IQueryAttributable
{
	CelestialObjectViewModel CviewModel;

	List<CelestialObject> CelestialObjects { get; set; }

	public string ListName { get; set; }

	public CelestialObjectPage()
	{
		InitializeComponent();
		CviewModel = new CelestialObjectViewModel();
        CelestialObjects = new();
		OnPropertyChanged();
		ResultList.ItemsSource = CelestialObjects;
	}

    public void ApplyQueryAttributes(IDictionary<string, object> query)
	{
		var list = query["SelectedList"] as string;
		ListName = list;
        if (ListName == "Planets")
        {
            foreach (Planet planet in CviewModel.Planets)
            {
                CelestialObjects.Add(planet);
            }
        }
        else if (ListName == "Stars")
        {
            foreach (Star star in CviewModel.Stars)
            {
                CelestialObjects.Add(star);
            }
        }
    }
}