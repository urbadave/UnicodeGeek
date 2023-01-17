using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UnicodeData;

[XmlRoot(ElementName = "emoji-source")]
public class EmojiSourceObj
{
    [XmlAttribute(AttributeName = "unicode")]
    public string? unicode { get; set; }

    [XmlAttribute(AttributeName = "docomo")]
    public string? docomo { get; set; }

    [XmlAttribute(AttributeName = "kddi")]
    public string? kddi { get; set; }
    
    [XmlAttribute(AttributeName = "softbank")]
    public string? softbank { get; set; }
}
