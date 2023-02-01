using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeFixer;

public class LetterRules
{
    public bool Delete { get; set; }
    public bool Keep { get; set; }
    public string? Swap { get; set; }

    public LetterRules() { }

    public LetterRules(bool delete, bool keep, string? swap)
    {
        Delete = delete; Keep = keep; Swap = swap;
    }
}
