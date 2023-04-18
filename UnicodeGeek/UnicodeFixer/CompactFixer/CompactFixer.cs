using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicodeFixer.FixerBuilder;

namespace UnicodeFixer.CompactFixer
{
    public class CompactFixer
    {
        private BuilderRules Rules;
        private List<LetterAction> Actions;

        public int Count
        {
            get { return Actions.Count; }
        }

        public string ActionsJson
        {
            get
            {
                var retVal = JsonConvert.SerializeObject(Actions);
                return retVal;
            }
        }

        public CompactFixer()
        {
            Rules = new BuilderRules();
            Actions = new List<LetterAction>();
        }

        public CompactFixer(BuilderRules rules): this()
        {
            this.Rules = rules;
            LoadActions();
        }

        private void LoadActions()
        {
            if (Rules == null) return;

            if(Rules.KeepGroups != null && Rules.KeepGroups.Any())
            {
                foreach(var group in Rules.KeepGroups)
                {
                    if(group.Indexes != null && group.Indexes.Any())
                    {
                        foreach(var i in group.Indexes)
                        {
                            Actions.Add(new LetterAction(i, $"{char.ConvertFromUtf32(i)}"));
                        }
                    }
                }
            }

            if(Rules.SwapGroups != null && Rules.SwapGroups.Any())
            {
                foreach (var group in Rules.SwapGroups)
                {
                    if(group.Swaps != null && group.Swaps.Any())
                    {
                        foreach(var s in group.Swaps)
                        {
                            Actions.Add(new LetterAction(s.Index, s.Swap));
                        }
                    }
                }
            }
            Actions.Sort();
        }
    }
}
