using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeFixer;

public class GroupRules
{
    public string? Name { get; set; }
    public Dictionary<int, LetterRules> Letters { get; set; } = new Dictionary<int, LetterRules>();

    public GroupRules() { }

    public GroupRules(string name)
    {
        Name = name;
    }

    public int AddDelete(int index)
    {
        Letters.Add(index, new LetterRules(true, false, null));
        return index;
    }

    public int AddKeep(int index)
    {
        Letters.Add(index, new LetterRules(false, true, null));
        return index;
    }

    public int AddSwap(int index, string? swap)
    {
        Letters.Add(index, new LetterRules(false, false, swap));
        return index;
    }
}
