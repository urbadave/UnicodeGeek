using Newtonsoft;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeFixer.FixerBuilder;

public class KeepBuilder
{
    [JsonProperty(PropertyName = "name")] 
    public string Name { get; set; } = string.Empty;

    [JsonProperty(PropertyName = "indexes")]
    public List<int> Indexes { get; set; } = new List<int>();
}
