// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using RelevantUnicode;
using System.Xml.Serialization;
using UnicodeData;
using UnicodeFixer;
using UnicodeFixer.FixerBuilder;

Console.WriteLine("XML Stuff");

//"C:\Users\18275\source\repos\UnicodeGeek\Data\SerializeTest1.xml"

string fileName = @"C:\Users\18275\source\repos\UnicodeGeek\Data\ucd.all.grouped\ucd.all.grouped.xml";
//string fileName = @"C:\Users\urban\source\repos\UnicodeGeek\Data\ucd.all.grouped\ucd.all.grouped.xml";
string outFileName = @"C:\UnicodeGeek\CharacterDtos.txt";
string groupDtoFile = @"C:\UnicodeGeek\GroupDtos.txt";
string builderFile = @"C:\UnicodeGeek\RulesMaster.json";
string fixerFile = @"C:\UnicodeGeek\FixerFile.json";
//string fileName = @"C:\Users\urban\source\repos\UnicodeGeek\Data\ucd.all.grouped\ucd.all.grouped.xml";

BuilderRules? builder = null;
var nothing = "nothing";

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

        FixerMaster fm = new();
        fm.LoadFixerMaster(builder, GroupDTOs);
        var swapArray = fm.FixerStrings;
        var fixerJson = fm.ArrayToJsonString();
        File.WriteAllText(fixerFile, fixerJson);

        //now put the data from fixer array into GroupDTOs list
        foreach(var g in GroupDTOs)
        {
            g.UpdateCharacters(swapArray);
        }

        Console.WriteLine($"GroupDTOs has {GroupDTOs.Count} relevant groups");

        List<string> fileLines = new();
        foreach (var g in GroupDTOs)
        {
            fileLines.Add($"{g.Name}: {g.FirstIndex}-{g.LastIndex}");
            foreach (var c in g.CharacterDTOs)
            {
                fileLines.Add($"  {c}");
            }
        }
        var fileText = string.Join("\n", fileLines);
        File.WriteAllText(outFileName, fileText);

        var GroupListJson = JsonConvert.SerializeObject(GroupDTOs);
        File.WriteAllText(groupDtoFile, GroupListJson);
    }
}


