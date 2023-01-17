using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UnicodeData
{
    public class Reserved
    {
        [XmlAttribute(AttributeName = "first-cp")]
        public string? FirstCP { get; set; }

        [XmlAttribute(AttributeName = "last-cp")]
        public string? LastCP { get; set; }

        [XmlAttribute(AttributeName = "DI")]
        public string? DI { get; set; }

        [XmlAttribute(AttributeName = "ODI")]
        public string? ODI { get; set; }

        [XmlAttribute(AttributeName = "GCB")]
        public string? GCB { get; set; }

        [XmlAttribute(AttributeName = "CWKCF")]
        public string? CWKCF { get; set; }

        [XmlAttribute(AttributeName = "NFKC_CF")]
        public string? NFKC_CF { get; set; }
    }
}
