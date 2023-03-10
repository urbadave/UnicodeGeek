using Newtonsoft;
using Newtonsoft.Json;
using RelevantUnicode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeFixer.FixerBuilder;

public class BuilderRules
{
    [JsonProperty(PropertyName = "irrelevantGroups")]
    public List<string> IrrelevantGroups { get; set; } = new List<string>();

    [JsonProperty(PropertyName = "keepGroups")]
    public List<KeepBuilder> KeepGroups { get; set; } = new List<KeepBuilder>();

    [JsonProperty(PropertyName = "swapGroups")]
    public List<SwapBuilder> SwapGroups { get; set; } = new List<SwapBuilder>();

    public BuilderRules() { }

}
