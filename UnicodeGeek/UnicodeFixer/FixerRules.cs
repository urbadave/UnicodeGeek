using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeFixer;

public class FixerRules
{
    public List<string> IrrelevantGroups { get; set; } = new List<string>();
    public List<GroupRules> RelevantGroups { get; set; } = new List<GroupRules>();
}
