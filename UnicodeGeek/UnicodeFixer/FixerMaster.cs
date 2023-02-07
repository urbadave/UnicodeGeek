﻿using Newtonsoft.Json;
using RelevantUnicode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicodeFixer.FixerBuilder;

namespace UnicodeFixer;

public class FixerMaster
{
    public Dictionary<int, LetterFixer> FixerList { get; set; } = new Dictionary<int, LetterFixer>();

    public BuilderRules Rules { get; set; }

    public bool IsLoaded { get; set; }

    public FixerMaster()
    {
        Rules = null;
        IsLoaded= false;
    }

    public void LoadFixerMaster(BuilderRules rules, List<GroupDTO> groups)
    {
        if (rules == null || groups == null) return;

        FixerList.Clear();
        IsLoaded = false;
        Rules = rules;
        foreach (GroupDTO group in groups)
        {
            ProcessGroup(group);
        }
        IsLoaded = true;
    }

    public string ToJsonString()
    {
        return JsonConvert.SerializeObject(FixerList);
    }

    private void ProcessGroup(GroupDTO group)
    {
        if (group == null || string.IsNullOrWhiteSpace(group.Name)) return;

        //check what kind of group this is
        if (Rules.IrrelevantGroups.Contains(group.Name))
        {
            ProcessIrrelevantGroup(group);
        }
        else if (Rules.KeepGroups.FirstOrDefault(kg => kg.Name == group.Name) != null)
        {
            ProcessKepGroup(group);
        }
        else if (Rules.SwapGroups.FirstOrDefault(sg => sg.Name == group.Name) != null)
        {
            ProcessSwapGroup(group);
        }
    }

    private void ProcessIrrelevantGroup(GroupDTO group)
    {
        if (group == null) return;
        //run from low to high index in group
        var low = GetIntFromCode(group.FirstCP);
        var high = GetIntFromCode(group.LastCP);
        if (low != null && high != null)
        {
            for (var i = low.Value; i <= high.Value; i++)
            {
                FixerList.Add(i, new LetterFixer(i, true, false, null));
            }
        }
    }

    private void ProcessKepGroup(GroupDTO group)
    {
        if (group == null) return;

        var keepBuilder = Rules.KeepGroups.First(kg => kg.Name == group.Name);
        var low = GetIntFromCode(group.FirstCP);
        var high = GetIntFromCode(group.LastCP);
        if (low != null && high != null)
        {
            for (var i = low.Value; i <= high.Value; i++)
            {
                if (keepBuilder.Indexes.Contains(i)) //add a keep letter fixer
                {
                    FixerList.Add(i, new LetterFixer(i, false, true, null));
                }
                else //add a drop letter fixer
                {
                    FixerList.Add(i, new LetterFixer(i, true, false, null));
                }
            }
        }
    }

    private void ProcessSwapGroup(GroupDTO group)
    {
        if (group == null) return;

        var swapBuilder = Rules.SwapGroups.First(kg => kg.Name == group.Name);
        var low = GetIntFromCode(group.FirstCP);
        var high = GetIntFromCode(group.LastCP);
        if (low != null && high != null)
        {
            for (var i = low.Value; i <= high.Value; i++)
            {
                var swap = swapBuilder.Swaps.FirstOrDefault(sw => sw.Index == i);
                if (swap != null) //add a Swap letter fixer
                {
                    FixerList.Add(i, new LetterFixer(i, false, false, swap.Swap));
                }
                else //add a drop letter fixer
                {
                    FixerList.Add(i, new LetterFixer(i, true, false, null));
                }
            }
        }
    }

    private int? GetIntFromCode(string? code)
    {
        if(string.IsNullOrWhiteSpace(code)) return null;

        var hex = $"0x{code}";
        var intVal = Convert.ToInt32(hex, 16);
        return intVal;
    }
}
