using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RocketClubs.ThrustCurve.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ThrustCurveServices services = new ThrustCurveServices();

            SearchParameters parameters = new SearchParameters()
            {
                Manufacturer = "AeroTech",
            };

            SearchResults results = services.Search(parameters);

        }
    }
}
