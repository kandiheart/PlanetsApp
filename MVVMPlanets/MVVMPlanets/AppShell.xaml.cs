using MVVMPlanets.Views;

namespace MVVMPlanets;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(CelestialObjectPage), typeof(CelestialObjectPage));
	}
}
