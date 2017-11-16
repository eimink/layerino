using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace layerino
{
    [JsonObject]
    public class ConfigData
    {
        [JsonProperty]
        public string HomeTeamName { get; set; }
        [JsonProperty]
        public string AwayTeamName { get; set; }
        [JsonProperty]
        public string HomeTeamScore { get; set; }
        [JsonProperty]
        public string AwayTeamScore { get; set; }
        [JsonProperty]
        public string TopLogo { get; set; }
        [JsonProperty]
        public string TopOverlay { get; set; }
    }
}
