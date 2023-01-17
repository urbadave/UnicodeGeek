using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UnicodeData;

[XmlRoot(ElementName = "block")]
public class Block
{
    [XmlAttribute(AttributeName = "first-cp")]
    public string? FirstCp { get; set; }

    [XmlAttribute(AttributeName = "last-cp")]
    public string? LastCp { get; set; }

    [XmlAttribute(AttributeName = "name")]
    public string? Name { get; set; }
}
