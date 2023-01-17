using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UnicodeData;

//<noncharacter first-cp="10FFFE" last-cp="10FFFF" gc="Cn" bc="BN" ea="N" NChar="Y" vo="R"/>

[XmlRoot(ElementName = "noncharacter")]
public class NonCharacter
{
    [XmlAttribute(AttributeName = "first-cp")]
    public string? FirstCp { get; set; }

    [XmlAttribute(AttributeName = "last-cp")]
    public string? LastCp { get; set; }

    [XmlAttribute(AttributeName = "gc")]
    public string? Gc { get; set; }

    [XmlAttribute(AttributeName = "bc")]
    public string? Bc { get; set; }

    [XmlAttribute(AttributeName = "ea")]
    public string? Ea { get; set; }

    [XmlAttribute(AttributeName = "NChar")]
    public string? NChar { get; set; }

    [XmlAttribute(AttributeName = "vo")]
    public string? Vo { get; set; }
}
