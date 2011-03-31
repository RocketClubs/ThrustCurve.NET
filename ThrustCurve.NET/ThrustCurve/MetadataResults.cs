using System;
using System.Xml.Serialization;

namespace RocketClubs.ThrustCurve
{
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.thrustcurve.org/2008/MetadataResponse")]
    [XmlRoot("metadata-response", Namespace = "http://www.thrustcurve.org/2008/MetadataResponse", IsNullable = false)]
    public partial class MetadataResults
    {
        [XmlArray(ElementName = "manufacturers")]
        [XmlArrayItem(ElementName = "manufacturer", IsNullable = false)]
        public NameAndAbbrev[] Manufacturers { get; set; }

        [XmlArray(ElementName = "cert-orgs")]
        [XmlArrayItem(ElementName = "cert-org", IsNullable = false)]
        public NameAndAbbrev[] CertificationOrganizations { get; set; }

        [XmlArray(ElementName = "types")]
        [XmlArrayItem(ElementName = "type", IsNullable = false)]
        public MotorType[] MotorTypes { get; set; }

        [XmlArray(ElementName = "diameters")]
        [XmlArrayItem(ElementName = "diameter", IsNullable = false)]
        public decimal[] Diameters { get; set; }

        [XmlArray(ElementName = "impulse-classes")]
        [XmlArrayItem(ElementName = "impulse-class", IsNullable = false)]
        public string[] ImpulseClasses { get; set; }

        [XmlElement(ElementName = "error")]
        public string Error { get; set; }
    }

    [System.Serializable()]
    [XmlType(Namespace = "http://www.thrustcurve.org/2008/MetadataResponse")]
    public partial class NameAndAbbrev
    {
        [XmlAttribute(AttributeName = "abbrev")]
        public string Abbreviation { get; set; }

        [XmlText()]
        public string Value { get; set; }
    }
}