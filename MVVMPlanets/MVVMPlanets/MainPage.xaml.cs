using MVVMPlanets.Models;
using MVVMPlanets.ViewModels;
using MVVMPlanets.Views;

namespace MVVMPlanets;


public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
    }

    private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        ListView item = sender as ListView;
        string var = item.SelectedItem as string;
        Navigation(var);
    }

    async Task Navigation(string s)
    {
        var parameter = new Dictionary<string, object>
        {
            {"SelectedList", s},
        };
        var route = $"{nameof(CelestialObjectPage)}";
        await Shell.Current.GoToAsync(route, parameter);
    }
}

