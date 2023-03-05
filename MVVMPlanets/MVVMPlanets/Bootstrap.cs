using Autofac;
using Autofac.Extras.CommonServiceLocator;
using CommonServiceLocator;
using MVVMPlanets.Services;
using MVVMPlanets.ViewModels;

namespace MVVMPlanets;

public class Bootstrap
{
	public Bootstrap()
	{
	}

	public static void Initialize()
	{
		ContainerBuilder builder = new();
		builder.RegisterType<BasePageViewModel>().AsSelf();
		builder.RegisterType<MainPageViewModel>().AsSelf();
		builder.RegisterType<CelestialObjectViewModel>().AsSelf();

		builder.RegisterType<PlanetService>().As<IPlanetService>();
		builder.RegisterType<StarService>().As<IStarService>();

		Autofac.IContainer container = builder.Build();
		AutofacServiceLocator asl = new AutofacServiceLocator(container);
		ServiceLocator.SetLocatorProvider(() => asl);
	}
}