using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UnicodeData
{
    [XmlRoot(ElementName = "normalization-correction")]
    public class NormalizationCorrectionObj
    {
        [XmlAttribute(AttributeName = "cp")]
        public string? Cp { get; set; }

        [XmlAttribute(AttributeName = "old")]
        public string? Old { get; set; }

        [XmlAttribute(AttributeName = "new")]
        public string? New { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public string? Version { get; set; }
    }
}
