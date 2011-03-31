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

            var parameters = new MetadataParameters()
            {
                Manufacturer = "AeroTech",
            };

            var results = services.Metadata(parameters);

        }
    }
}
