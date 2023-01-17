using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicodeData;

namespace RelevantUnicode;

public class CharacterDTO: IComparable<CharacterDTO>
{
    public string? CP { get; set; }

    public CharacterDTO()
    { }

    public CharacterDTO(CharObj source)
    {
        if (source != null)
        {
            CP = source.Cp;
        }
    }

    public int CompareTo(CharacterDTO? other)
    {
        if (other == null) return -1;
        return CP.CompareTo(other.CP);
    }
}
