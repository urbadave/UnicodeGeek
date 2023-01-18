using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UnicodeData;

//<char first-cp="100000" last-cp="10FFFD" gc="Co" bc="L" ea="A" NChar="N" vo="U"/>

[XmlRoot(ElementName = "char")]
public class CharObj
{
    #region Attributes
    [XmlAttribute(AttributeName = "cp")]
    public string? Cp { get; set; }

    [XmlAttribute(AttributeName = "na")]
    public string? Na { get; set; }

    [XmlAttribute(AttributeName = "na1")]
    public string? Na1 { get; set; }

    [XmlAttribute(AttributeName = "first-cp")]
    public string? FirstCp { get; set; }

    [XmlAttribute(AttributeName = "last-cp")]
    public string? LastCp { get; set; }

    [XmlAttribute(AttributeName = "gc")]
    public string? Gc { get; set; }

    [XmlAttribute(AttributeName = "bc")]
    public string? Bc { get; set; }

    [XmlAttribute(AttributeName = "lb")]
    public string? Lb { get; set; }

    [XmlAttribute(AttributeName = "ea")]
    public string? Ea { get; set; }

    [XmlAttribute(AttributeName = "NChar")]
    public string? NChar { get; set; }

    [XmlAttribute(AttributeName = "vo")]
    public string? Vo { get; set; }

    [XmlAttribute(AttributeName = "WSpace")]
    public string? WSpace { get; set; }

    [XmlAttribute(AttributeName = "Pat_WS")]
    public string? Pat_WS { get; set; }

    [XmlAttribute(AttributeName = "SB")]
    public string? SB { get; set; }

    [XmlAttribute(AttributeName = "GCB")]
    public string? GCB { get; set; }
    #endregion

    #region Elements
    [XmlElement(ElementName = "name-alias")]
    public List<NameAlias> NameAlias { get; set; }
    #endregion
}
