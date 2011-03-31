using System;
using System.Xml.Serialization;

namespace RocketClubs.ThrustCurve
{
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.thrustcurve.org/2009/DownloadRequest")]
    [XmlRoot("download-request", Namespace = "http://www.thrustcurve.org/2009/DownloadRequest", IsNullable = false)]
    public partial class DownloadParameters
    {
        [XmlElement(ElementName = "motor-id")]
        public int ThrustCurveId { get; set; }

        [XmlElement(ElementName = "format")]
        public DownloadFormat? Format { get; set; }

        [XmlIgnore()]
        public bool FormatSpecified { get { return Format.HasValue; } }

        [XmlElement(ElementName = "license")]
        public DownloadLicense? License { get; set; }

        [XmlIgnore()]
        public bool LicenseSpecified { get { return License.HasValue; } }

        [XmlElement(ElementName = "max-results")]
        public int? MaxResults { get; set; }

        [XmlIgnore()]
        public bool MaxResultsSpecified { get { return MaxResults.HasValue; } }
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.thrustcurve.org/2009/DownloadRequest")]
    public enum DownloadFormat
    {
        CompuRoc,
        ALT4,
        RASP,
        RockSim,
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.thrustcurve.org/2009/DownloadRequest")]
    public enum DownloadLicense
    {
        PD,
        free,
        other,
        [XmlEnum("")]
        Item,
    }
}