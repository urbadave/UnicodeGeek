using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using UnicodeData;

namespace RelevantUnicode;

[DebuggerDisplay("{FirstCP}-{LastCP}: {Name}")]
public class BlockDTO
{
    public string? Name { get; set; }
    public string? FirstCP { get; set; }
    public string? LastCP { get; set; }

    public BlockDTO() { }

    public BlockDTO(Block source)
    {
        if(source != null)
        {
            Name = source.Name;
            FirstCP = source.FirstCp;
            LastCP = source.LastCp;
        }
    }

    public bool IsInRangs(string? firstCP, string? lastCP)
    {
        if (firstCP == null || lastCP == null) return false;
        if (FirstCP == null || LastCP == null) return false;

        if (firstCP == FirstCP) return true;

        if (lastCP == LastCP) return true;

        if (firstCP.CompareTo(FirstCP) > 0 && lastCP.CompareTo(LastCP) < 0)
            return true;

        return false;
    }
}
