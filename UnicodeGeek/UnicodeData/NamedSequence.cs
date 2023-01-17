using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UnicodeData
{
    [XmlRoot(ElementName = "named-sequence")]
    public class NamedSequence
    {
        [XmlAttribute(AttributeName = "name")]
        public string? Name { get; set; }

        [XmlAttribute(AttributeName = "cps")]
        public string? Cps { get; set; }
    }
}
