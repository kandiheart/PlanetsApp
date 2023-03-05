using MVVMPlanets.Models;
using Newtonsoft.Json;
using System.Reflection;

namespace MVVMPlanets.Services
{
    public class PlanetService : IPlanetService
    {
        public PlanetService() { }

        public List<Planet> GetThePlanets()
        {
            var assembly = typeof(PlanetService).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("MVVMPlanets.planets.json");

            using (var reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                try
                {
                    var data = JsonConvert.DeserializeObject<Root>(json);
                    return data.planets;
                }
                catch(Exception ex) 
                {
                    System.Diagnostics.Debug.WriteLine(ex.StackTrace);
                    return null;
                }
            }
        }
    }
}
