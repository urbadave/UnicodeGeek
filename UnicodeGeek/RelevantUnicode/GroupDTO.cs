using UnicodeData;

namespace RelevantUnicode;

public class GroupDTO
{
    public string? FirstCP { get; set; }
    public string? LastCP { get; set; }

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
        }
    }
}