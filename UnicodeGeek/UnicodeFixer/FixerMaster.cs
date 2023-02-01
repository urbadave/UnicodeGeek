using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeFixer;

public class FixerMaster
{
    public Dictionary<int, LetterFixer> FixerList { get; set; } = new Dictionary<int, LetterFixer>();
}
