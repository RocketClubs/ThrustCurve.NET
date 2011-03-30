using System;
using System.Xml.Serialization;

namespace RocketClubs.ThrustCurve
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.thrustcurve.org/2008/SearchRequest")]
    [XmlRoot("search-request", Namespace = "http://www.thrustcurve.org/2008/SearchRequest", IsNullable = false)]
    public partial class SearchParameters
    {
        [XmlElement(ElementName = "manufacturer")]
        public string Manufacturer { get; set; }

        [XmlElement(ElementName = "designation")]
        public string Designation { get; set; }

        [XmlElement(ElementName = "brand-name")]
        public string BrandName { get; set; }

        [XmlElement(ElementName = "common-name")]
        public string CommonName { get; set; }

        [XmlElement(ElementName = "impulse-class")]
        public string ImpulseClass { get; set; }

        [XmlElement(ElementName = "diameter")]
        public decimal? Diameter { get; set; }

        [XmlIgnore()]
        public bool DiameterSpecified { get { return Diameter.HasValue; } }

        [XmlElement(ElementName = "")]
        public MotorType? MotorType { get; set; }

        [XmlIgnore()]
        public bool MotorTypeSpecified { get { return MotorType.HasValue; } }

        [XmlElement(ElementName = "cert-org")]
        public string CertiicationOrganization { get; set; }

        [XmlElement(ElementName = "has-data-files")]
        public bool? HasDataFiles { get; set; }

        [XmlIgnore()]
        public bool HasDataFilesSpecified { get { return HasDataFiles.HasValue; } }

        [XmlElement(ElementName = "info-updated-since")]
        public DateTime? LastInfoUpdateDate { get; set; }

        [XmlIgnore()]
        public bool LastInfoUpdateDateSpecified { get { return LastInfoUpdateDate.HasValue; } }

        [XmlElement(ElementName = "data-updated-since")]
        public DateTime? LastDataUpdateDate { get; set; }

        [XmlIgnore()]
        public bool LastDataUpdateDateSpecified { get { return LastDataUpdateDate.HasValue; } }

        [XmlElement(ElementName = "max-results")]
        public int? MaxResults { get; set; }
        
        [XmlIgnore()]
        public bool MaxResultsSpecified { get { return MaxResults.HasValue; } }
    }

    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.thrustcurve.org/2008/SearchRequest")]
    public enum MotorType
    {
        [XmlEnum(Name = "SU")]
        SingleUse,
        [XmlEnum(Name = "reload")]
        Reload,
        [XmlEnum(Name = "hybrid")]
        Hybrid,
    }
}