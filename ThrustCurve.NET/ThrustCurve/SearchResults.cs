﻿using System.Xml.Serialization;

namespace RocketClubs.ThrustCurve
{

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.thrustcurve.org/2008/SearchResponse")]
    [System.Xml.Serialization.XmlRootAttribute("search-response", Namespace = "http://www.thrustcurve.org/2008/SearchResponse", IsNullable = false)]
    public partial class searchresponse
    {

        private searchresponseCriteria criteriaField;

        private searchresponseResult[] resultsField;

        private string errorField;

        /// <remarks/>
        public searchresponseCriteria criteria
        {
            get
            {
                return this.criteriaField;
            }
            set
            {
                this.criteriaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("result", IsNullable = false)]
        public searchresponseResult[] results
        {
            get
            {
                return this.resultsField;
            }
            set
            {
                this.resultsField = value;
            }
        }

        /// <remarks/>
        public string error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.thrustcurve.org/2008/SearchResponse")]
    public partial class searchresponseCriteria
    {

        private searchresponseCriteriaCriterion[] criterionField;

        private string matchesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("criterion")]
        public searchresponseCriteriaCriterion[] criterion
        {
            get
            {
                return this.criterionField;
            }
            set
            {
                this.criterionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string matches
        {
            get
            {
                return this.matchesField;
            }
            set
            {
                this.matchesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.thrustcurve.org/2008/SearchResponse")]
    public partial class searchresponseCriteriaCriterion
    {

        private string nameField;

        private string valueField;

        private string matchesField;

        private string errorField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string matches
        {
            get
            {
                return this.matchesField;
            }
            set
            {
                this.matchesField = value;
            }
        }

        /// <remarks/>
        public string error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.thrustcurve.org/2008/SearchResponse")]
    public partial class searchresponseResult
    {

        private string motoridField;

        private string manufacturerField;

        private string designationField;

        private string brandnameField;

        private string commonnameField;

        private string impulseclassField;

        private decimal diameterField;

        private string typeField;

        private string certorgField;

        private decimal avgthrustnField;

        private bool avgthrustnFieldSpecified;

        private decimal maxthrustnField;

        private bool maxthrustnFieldSpecified;

        private decimal totimpulsensField;

        private bool totimpulsensFieldSpecified;

        private decimal burntimesField;

        private bool burntimesFieldSpecified;

        private string datafilesField;

        private string infourlField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("motor-id", DataType = "integer")]
        public string motorid
        {
            get
            {
                return this.motoridField;
            }
            set
            {
                this.motoridField = value;
            }
        }

        /// <remarks/>
        public string manufacturer
        {
            get
            {
                return this.manufacturerField;
            }
            set
            {
                this.manufacturerField = value;
            }
        }

        /// <remarks/>
        public string designation
        {
            get
            {
                return this.designationField;
            }
            set
            {
                this.designationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("brand-name")]
        public string brandname
        {
            get
            {
                return this.brandnameField;
            }
            set
            {
                this.brandnameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("common-name")]
        public string commonname
        {
            get
            {
                return this.commonnameField;
            }
            set
            {
                this.commonnameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("impulse-class")]
        public string impulseclass
        {
            get
            {
                return this.impulseclassField;
            }
            set
            {
                this.impulseclassField = value;
            }
        }

        /// <remarks/>
        public decimal diameter
        {
            get
            {
                return this.diameterField;
            }
            set
            {
                this.diameterField = value;
            }
        }

        /// <remarks/>
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cert-org")]
        public string certorg
        {
            get
            {
                return this.certorgField;
            }
            set
            {
                this.certorgField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("avg-thrust-n")]
        public decimal avgthrustn
        {
            get
            {
                return this.avgthrustnField;
            }
            set
            {
                this.avgthrustnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool avgthrustnSpecified
        {
            get
            {
                return this.avgthrustnFieldSpecified;
            }
            set
            {
                this.avgthrustnFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("max-thrust-n")]
        public decimal maxthrustn
        {
            get
            {
                return this.maxthrustnField;
            }
            set
            {
                this.maxthrustnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxthrustnSpecified
        {
            get
            {
                return this.maxthrustnFieldSpecified;
            }
            set
            {
                this.maxthrustnFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tot-impulse-ns")]
        public decimal totimpulsens
        {
            get
            {
                return this.totimpulsensField;
            }
            set
            {
                this.totimpulsensField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totimpulsensSpecified
        {
            get
            {
                return this.totimpulsensFieldSpecified;
            }
            set
            {
                this.totimpulsensFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("burn-time-s")]
        public decimal burntimes
        {
            get
            {
                return this.burntimesField;
            }
            set
            {
                this.burntimesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool burntimesSpecified
        {
            get
            {
                return this.burntimesFieldSpecified;
            }
            set
            {
                this.burntimesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("data-files", DataType = "integer")]
        public string datafiles
        {
            get
            {
                return this.datafilesField;
            }
            set
            {
                this.datafilesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("info-url", DataType = "anyURI")]
        public string infourl
        {
            get
            {
                return this.infourlField;
            }
            set
            {
                this.infourlField = value;
            }
        }
    }
}