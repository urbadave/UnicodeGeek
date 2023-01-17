using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UnicodeData
{
    [XmlRoot(ElementName = "standardized-variant")]
    public class StandardizedVariantObj
    {
        [XmlAttribute(AttributeName = "cps")]
        public string? Cps { get; set; }

        [XmlAttribute(AttributeName = "desc")]
        public string? Desc { get; set; }

        [XmlAttribute(AttributeName = "when")]
        public string? When { get; set; }
    }
}
