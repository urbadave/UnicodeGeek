using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeFixer.FixerBuilder;

public class LetterSwapBuilder
{
    [JsonProperty(PropertyName = "index")]
    public int Index { get; set; }

    [JsonProperty(PropertyName = "swap")]
    public string Swap { get; set; } = string.Empty;
}
