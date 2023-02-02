// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using RelevantUnicode;
using System.Xml.Serialization;
using UnicodeData;
using UnicodeFixer.FixerBuilder;

Console.WriteLine("XML Stuff");

//"C:\Users\18275\source\repos\UnicodeGeek\Data\SerializeTest1.xml"

string fileName = @"C:\Users\18275\source\repos\UnicodeGeek\Data\ucd.all.grouped\ucd.all.grouped.xml";
string outFileName = @"C:\UnicodeGeek\CharacterDtos.txt";
string builderFile = @"C:\UnicodeGeek\RulesMaster.json";
//string fileName = @"C:\Users\urban\source\repos\UnicodeGeek\Data\ucd.all.grouped\ucd.all.grouped.xml";

BuilderRules? builder = null;

using (StreamReader fileReader = new StreamReader(builderFile))
{
    var builderJson = fileReader.ReadToEnd().Trim();
    builder = JsonConvert.DeserializeObject<BuilderRules>(builderJson);
}

using (StreamReader xmlReader = new StreamReader(fileName))
{
    XmlSerializer xmlSerializer = new XmlSerializer(typeof(UcdObj));

    var ucdDatabase = (UcdObj)xmlSerializer.Deserialize(xmlReader);
    if (ucdDatabase != null && ucdDatabase.Blocks != null)
    {
        Console.WriteLine($"Database has {ucdDatabase.Repertoire.Count} groups");

        List<GroupDTO> GroupDTOs = new(ucdDatabase.Repertoire.Select(g => new GroupDTO(g)));
        List<BlockDTO> BlockDTOs = new(ucdDatabase.Blocks.Select(b => new BlockDTO(b)));

        GroupDTOs = GroupDTOs.Where(g => g.FirstCP != null && g.FirstCP.Length < 5).ToList();
        GroupDTOs.ForEach(g => g.FillName(BlockDTOs));

        Console.WriteLine($"GroupDTOs has {GroupDTOs.Count} relevant groups");

        List<string> fileLines = new();
        foreach (var g in GroupDTOs)
        {
            fileLines.Add($"{g.Name}: {g.FirstCP}-{g.LastCP}");
            foreach (var c in g.CharacterDTOs)
            {
                fileLines.Add($"  {c}");
            }
        }
        var fileText = string.Join("\n", fileLines);
        File.WriteAllText(outFileName, fileText);
    }
}


