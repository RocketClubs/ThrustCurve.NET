using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RocketClubs.ThrustCurve.Test
{
    class Program
    {
        static ThrustCurveServices services = new ThrustCurveServices();

        static void Main(string[] args)
        {
            TestSearch();
            TestMetadata();
            TestDownload();
        }

        static void TestDownload()
        {
            var parameters = new DownloadParameters()
            {
                ThrustCurveId = 33,
            };

            var results = services.Download(parameters);
        }

        static void TestSearch()
        {
            var parameters = new SearchParameters()
            {
                Manufacturer = "Aerotech",
            };

            var results = services.Search(parameters);
        }

        static void TestMetadata()
        {
            var parameters = new MetadataParameters()
            {
                Manufacturer = "Aerotech",
            };

            var results = services.Metadata(parameters);
        }
    }
}
