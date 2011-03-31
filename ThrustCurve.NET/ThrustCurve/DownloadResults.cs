using System;
using System.Xml.Serialization;

namespace RocketClubs.ThrustCurve
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.thrustcurve.org/2009/DownloadResponse")]
    [XmlRoot("download-response", Namespace = "http://www.thrustcurve.org/2009/DownloadResponse", IsNullable = false)]
    public partial class DownloadResults
    {
        [XmlArray(ElementName = "results")]
        [XmlArrayItem("result", IsNullable = false)]
        public DownloadInfoAndData[] Results { get; set; }

        [XmlElement(ElementName = "error")]
        public string Error { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.thrustcurve.org/2009/DownloadResponse")]
    public partial class DownloadInfoAndData
    {
        [XmlElement(ElementName = "motor-id")]
        public int ThrustCurveId { get; set; }

        [XmlElement(ElementName = "simfile-id")]
        public int SimFileId { get; set; }

        [XmlElement(ElementName = "format")]
        public DownloadFormat Format { get; set; }

        [XmlElement(ElementName = "source")]
        public DownloadSource Source { get; set; }

        [XmlElement(ElementName = "license")]
        public DownloadLicense License { get; set; }

        [XmlElement(ElementName = "data", DataType = "base64Binary")]
        public byte[] Data { get; set; }

        [XmlElement(ElementName = "info-url")]
        public string InfoUrl { get; set; }

        [XmlElement(ElementName = "data-url")]
        public string DataUrl { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.thrustcurve.org/2009/DownloadResponse")]
    public enum DownloadSource
    {
        cert,
        mfr,
        user,
    }
}