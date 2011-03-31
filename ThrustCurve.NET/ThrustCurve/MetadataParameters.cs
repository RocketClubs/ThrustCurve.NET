using System;
using System.Xml.Serialization;

namespace RocketClubs.ThrustCurve
{
    [System.Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.thrustcurve.org/2008/MetadataRequest")]
    [XmlRoot("metadata-request", Namespace = "http://www.thrustcurve.org/2008/MetadataRequest", IsNullable = false)]
    public partial class MetadataParameters
    {
        [XmlElement(ElementName = "manufacturer")]
        public string Manufacturer { get; set; }

        [XmlElement(ElementName = "impulse-class")]
        public string ImpulseClass { get; set; }

        [XmlElement(ElementName = "diameter")]
        public decimal? Diameter { get; set; }

        [XmlIgnore()]
        public bool DiameterSpecified { get { return Diameter.HasValue; } }

        [XmlElement(ElementName = "type")]
        public MotorType? MotorType { get; set; }

        [XmlIgnore()]
        public bool MotorTypeSpecified { get { return MotorType.HasValue; } }

        [XmlElement(ElementName = "cert-org")]
        public string CertiicationOrganization { get; set; }
    }
}