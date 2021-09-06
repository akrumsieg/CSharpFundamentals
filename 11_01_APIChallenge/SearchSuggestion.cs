using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_01_APIChallenge
{
    public class SearchSuggestion
    {
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("magicKey")]

        public string MagicKey { get; set; }
        [JsonProperty("isCollection")]

        public bool IsCollection { get; set; }
    }
}
