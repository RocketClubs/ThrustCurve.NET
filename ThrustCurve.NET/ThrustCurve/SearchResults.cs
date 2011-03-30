using System;
using System.Xml.Serialization;

namespace RocketClubs.ThrustCurve
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.thrustcurve.org/2008/SearchResponse")]
    [XmlRoot("search-response", Namespace = "http://www.thrustcurve.org/2008/SearchResponse", IsNullable = false)]
    public partial class SearchResults
    {
        [XmlElement(ElementName = "criteria")]
        public SearchResultsCriteria Criteria { get; set; }

        [XmlArrayItem(ElementName = "result", IsNullable = false)]
        public MotorInfo[] results { get; set; }

        [XmlElement(ElementName = "error")]
        public string Error { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.thrustcurve.org/2008/SearchResponse")]
    public partial class SearchResultsCriteria
    {
        [XmlElement(ElementName = "criterion")]
        public SearchResultsCriterion[] Criterion { get; set; }

        [XmlElement(ElementName = "matches")]
        public int Matches { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.thrustcurve.org/2008/SearchResponse")]
    public partial class SearchResultsCriterion
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "value")]
        public string Value { get; set; }

        [XmlElement(ElementName = "matches")]
        public int Matches { get; set; }

        [XmlElement(ElementName = "error")]
        public string Error { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.thrustcurve.org/2008/SearchResponse")]
    public partial class MotorInfo
    {
        [XmlElement(ElementName = "motor-id")]
        public int ThrustCurveId { get; set; }

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
        public decimal Diameter { get; set; }

        [XmlElement(ElementName = "type")]
        public MotorType MotorType { get; set; }

        [XmlElement(ElementName = "cert-org")]
        public string CertiicationOrganization { get; set; }

        [XmlElement(ElementName = "avg-thrust-n")]
        public decimal? AverageThurstInNewtons { get; set; }

        [XmlIgnore()]
        public bool AverageThurstInNewtonsSpecified { get { return AverageThurstInNewtons.HasValue; } }

        [XmlElement(ElementName = "max-thrust-n")]
        public decimal? MaxThrustInNewtons { get; set; }

        [XmlIgnore()]
        public bool MaxThrustInNewtonsSpecified { get { return MaxThrustInNewtons.HasValue; } }

        [XmlElement(ElementName = "tot-impulse-ns")]
        public decimal? TotalImpluseNewtonSeconds { get; set; }

        [XmlIgnore()]
        public bool TotalImpluseNewtonSecondsSpecified { get { return TotalImpluseNewtonSeconds.HasValue; } }

        [XmlElement(ElementName = "burn-time-s")]
        public decimal? BurnTimeInSeconds { get; set; }

        [XmlIgnore()]
        public bool BurnTimeInSecondsSpecified { get { return BurnTimeInSeconds.HasValue; } }

        [XmlElement(ElementName = "data-files")]
        public int DataFilesCount { get; set; }

        [XmlElement(ElementName = "info-url")]
        public string InfoUrl { get; set; }
    }
}