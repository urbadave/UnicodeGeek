using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeFixer.CompactFixer
{
    public class LetterAction: IComparable<LetterAction>
    {
        public int Index { get; set; }
        public string Output { get; set; }

        public LetterAction()
        {
            Index = 0;
            Output = string.Empty;
        }

        public LetterAction(int index, string output)
        {
            Index = index;
            Output = output;
        }

        public int CompareTo(LetterAction? other)
        {
            if(other == null) return -1;
            return Index - other.Index;
        }
    }
}
