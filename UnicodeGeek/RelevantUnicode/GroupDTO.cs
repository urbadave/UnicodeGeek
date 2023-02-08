using System.Diagnostics;
using UnicodeData;

namespace RelevantUnicode;

[DebuggerDisplay("{FirstIndex}-{LastIndex}: {Name}")]
public class GroupDTO
{
    public string? FirstCP { get; set; }
    public string? LastCP { get; set; }
    public string? Name { get; set; }
    public int? FirstIndex { get; set; }
    public int? LastIndex { get; set; }

    public List<CharacterDTO> CharacterDTOs { get; set; }

    public GroupDTO()
    {
        CharacterDTOs = new List<CharacterDTO>();
    }

    public GroupDTO(GroupObj source): this()
    {
        if(source != null && source.Char != null && source.Char.Any())
        {
            CharacterDTOs.AddRange(source.Char.Select(c => new CharacterDTO(c)));
            CharacterDTOs.Sort();
            FirstCP = CharacterDTOs.First()?.CP;
            LastCP = CharacterDTOs.Last()?.CP;
            FirstIndex = GetIntFromCode(FirstCP);
            LastIndex = GetIntFromCode(LastCP);
        }
    }

    public void FillName(List<BlockDTO> blocks)
    {
        if(blocks != null)
        {
            var foundBlock = blocks.FirstOrDefault(b => b.IsInRangs(FirstCP, LastCP));
            if(foundBlock != null)
                Name = foundBlock.Name;
        }
    }

    public void UpdateCharacters(string[] swapArray)
    {
        foreach(var c in CharacterDTOs)
        {
            c.UpdateSwap(swapArray);
        }
    }

    private int? GetIntFromCode(string? code)
    {
        if (string.IsNullOrWhiteSpace(code)) return null;

        var hex = $"0x{code}";
        var intVal = Convert.ToInt32(hex, 16);
        return intVal;
    }
}