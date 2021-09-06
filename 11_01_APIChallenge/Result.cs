using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_01_APIChallenge
{
    public class Result<SearchSuggestion>
    {
        [JsonProperty("suggestions")]
        public List<SearchSuggestion> Suggestions { get; set; }
    }
}
