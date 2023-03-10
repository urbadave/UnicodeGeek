using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicodeData;

namespace RelevantUnicode;

[DebuggerDisplay("{CP} {Name}")]
public class CharacterDTO: IComparable<CharacterDTO>
{
    public string? CP { get; set; }
    public string? Name { get; set; }
    public string? IntVal { get; set; }
    public string? Rep { get; set; }
    public string? Swap { get; set; }

    public CharacterDTO()
    { }

    public CharacterDTO(CharObj source)
    {
        if (source != null)
        {
            CP = source.Cp;
            Name = ExtractName(source);
            IntVal = ExtractIt(source);
        }
    }

    public void UpdateSwap(string[] swapArray)
    {
        if(IntVal != null)
        {
            var index = int.Parse(IntVal);
            Swap = swapArray[index];
        }
    }

    private string? ExtractName(CharObj source)
    {
        if(source == null) return null;

        var useName = (source.Na != null) ? source.Na : source.Na1;
        if(source.NameAlias != null && source.NameAlias.Any())
        {
            foreach(var na in source.NameAlias)
            {
                int unLength = (useName != null) ? useName.Length : 0;
                if (na.Alias != null && na.Alias.Length < unLength)
                    useName = na.Alias;
            }
        }
        return useName;
    }

    private string? ExtractIt(CharObj source)
    {
        if (source == null) return null;
        if(source.Cp != null)
        {
            var hex = $"0x{source.Cp}";
            var intVal = Convert.ToInt32(hex, 16);
            Rep = char.ConvertFromUtf32(intVal);
            return $"{intVal}";
        }
        return null;
    }

    public override string ToString()
    {
        var hex = $"0x{CP}";
        var intVal = Convert.ToInt32(hex, 16);

        var rep = " ";
        if (Rep != null)
        {
            if (string.IsNullOrWhiteSpace(Rep))
                rep = " ";
            else
                rep = Rep;
        }

        var action = string.Empty;
        if (Swap == null || Swap == string.Empty)
        {
            action = "Skip";
        }
        else
        {
            action = $"Add {Swap}";
        }
        return $"{intVal} {CP} {rep} {Name} {action}";
    }

    public int CompareTo(CharacterDTO? other)
    {
        if (other == null) return -1;
        return CP.CompareTo(other.CP);
    }
}
