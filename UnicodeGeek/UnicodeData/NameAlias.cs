using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UnicodeData
{
    [XmlRoot(ElementName = "name-alias")]
    public class NameAlias
    {
        [XmlAttribute(AttributeName = "alias")]
        public string? Alias { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public string? Type { get; set; }
    }
}
