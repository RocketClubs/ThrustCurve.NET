using System.Net;
using System.Xml.Serialization;

namespace RocketClubs.ThrustCurve
{
    public class ThrustCurveServices
    {
        private const string SEARCH_API_URL = "http://www.thrustcurve.org/servlets/search";
        private const string DOWNLOAD_API_URL = "http://www.thrustcurve.org/servlets/download";
        private const string METADATA_API_URL = "http://www.thrustcurve.org/servlets/metadata";

        public SearchResults Search(SearchParameters parameters)
        {
            return MakeServiceRequest<SearchResults>(SEARCH_API_URL, parameters);
        }

        public MetadataResults Metadata(MetadataParameters parameters)
        {
            return MakeServiceRequest<MetadataResults>(METADATA_API_URL, parameters);
        }

        public DownloadResults Download(DownloadParameters parameters)
        {
            return MakeServiceRequest<DownloadResults>(DOWNLOAD_API_URL, parameters);
        }

        private T MakeServiceRequest<T>(string serviceUrl, object parameters)
        {
            T results = default(T);

            HttpWebRequest serviceRequest = WebRequest.Create(serviceUrl) as HttpWebRequest;
            serviceRequest.Method = "POST";

            var xmlSerializer = new XmlSerializer(parameters.GetType());
            xmlSerializer.Serialize(serviceRequest.GetRequestStream(), parameters);
            
            HttpWebResponse serviceResponse = serviceRequest.GetResponse() as HttpWebResponse;
            if (serviceResponse.StatusCode == HttpStatusCode.OK)
            {
                var responseSerializer = new XmlSerializer(typeof(T));
                results = (T)responseSerializer.Deserialize(serviceResponse.GetResponseStream());
            }

            return results;
        }
    }
}
