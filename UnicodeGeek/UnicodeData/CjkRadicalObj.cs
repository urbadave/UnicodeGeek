using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UnicodeData;

[XmlRoot(ElementName = "emoji-source")]
public class CjkRadicalObj
{
    [XmlAttribute(AttributeName = "number")]
    public string Number { get; set; }

    [XmlAttribute(AttributeName = "radical")]
    public string Radical { get; set; }

    [XmlAttribute(AttributeName = "ideograph")]
    public string Ideograph { get; set; }
}
