using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeFixer.FixerBuilder;

public class SwapBuilder
{
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty(PropertyName = "swaps")]
    public List<LetterSwapBuilder> Swaps { get; set; } = new List<LetterSwapBuilder>();
}
