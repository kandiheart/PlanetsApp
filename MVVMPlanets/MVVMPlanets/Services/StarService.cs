using MVVMPlanets.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MVVMPlanets.Services
{
    public class StarService : IStarService
    {
        public StarService() { }

        public List<Star> GetTheStars()
        {
            var assembly = typeof(PlanetService).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("MVVMPlanets.stars.json");

            using (var reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                try
                {
                    var data = JsonConvert.DeserializeObject<Root>(json);
                    return data.stars;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.StackTrace);
                    return null;
                }
            }
        }
    }
}
