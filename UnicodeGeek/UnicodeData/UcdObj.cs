using System.Xml.Serialization;

namespace UnicodeData;

[XmlRoot(ElementName = "ucd")]
public class UcdObj
{
    [XmlElement(ElementName = "description")]
    [XmlText]
    public string Description { get; set; }

    [XmlArray("repertoire")]
    [XmlArrayItem("group")] 
    public List<GroupObj> Repertoire { get; set; }

    [XmlArray("blocks")]
    [XmlArrayItem("block")]
    public List<Block>? Blocks { get; set; }

    [XmlArray("named-sequences")]
    [XmlArrayItem("named-sequence")]
    public List<NamedSequence> NamedSequences { get; set; }

    [XmlArray("normalization-corrections")]
    [XmlArrayItem("normalization-correction")]
    public List<NormalizationCorrectionObj>? NormalizationCorrections { get; set; }

    [XmlArray("standardized-variants")]
    [XmlArrayItem("standardized-variant")]
    public List<StandardizedVariantObj>? StandardizedVariants { get; set; }

    [XmlArray("cjk-radicals")]
    [XmlArrayItem("cjk-radical")]
    public List<CjkRadicalObj>? CjkRadicals { get; set; }

    [XmlArray("emoji-sources")]
    [XmlArrayItem("emoji-source")]
    public List<EmojiSourceObj>? EmojiSources { get; set; }
}