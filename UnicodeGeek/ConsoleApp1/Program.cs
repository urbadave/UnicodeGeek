// See https://aka.ms/new-console-template for more information
using RelevantUnicode;
using System.Xml.Serialization;
using UnicodeData;

Console.WriteLine("XML Stuff");

//"C:\Users\18275\source\repos\UnicodeGeek\Data\SerializeTest1.xml"

using (StreamReader xmlReader = new StreamReader(@"C:\Users\18275\source\repos\UnicodeGeek\Data\ucd.all.grouped\ucd.all.grouped.xml"))
{
    XmlSerializer xmlSerializer = new XmlSerializer(typeof(UcdObj));
    var ucdDatabase = (UcdObj)xmlSerializer.Deserialize(xmlReader);

    Console.WriteLine($"Database has {ucdDatabase.Repertoire.Count} groups");

    List<GroupDTO> GroupDTOs = new(ucdDatabase.Repertoire.Select(g => new GroupDTO(g)));
    List<BlockDTO> BlockDTOs = new(ucdDatabase.Blocks.Select(b => new BlockDTO(b)));

    GroupDTOs = GroupDTOs.Where(g => g.FirstCP != null && g.FirstCP.Length < 5).ToList();
    GroupDTOs.ForEach(g => g.FillName(BlockDTOs));

    Console.WriteLine($"GroupDTOs has {GroupDTOs.Count} relevant groups");
}


