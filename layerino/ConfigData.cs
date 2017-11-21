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
        [JsonProperty]
        public string Team1Name { get; set; }
        [JsonProperty]
        public string Team2Name { get; set; }
        [JsonProperty]
        public string Team3Name { get; set; }
        [JsonProperty]
        public string Team4Name { get; set; }
        [JsonProperty]
        public string Team5Name { get; set; }
        [JsonProperty]
        public string Team6Name { get; set; }
        [JsonProperty]
        public string Team7Name { get; set; }
        [JsonProperty]
        public string Team8Name { get; set; }
        [JsonProperty]
        public string Semi1Name { get; set; }
        [JsonProperty]
        public string Semi2Name { get; set; }
        [JsonProperty]
        public string Semi3Name { get; set; }
        [JsonProperty]
        public string Semi4Name { get; set; }
        [JsonProperty]
        public string Final1Name { get; set; }
        [JsonProperty]
        public string Final2Name { get; set; }
        [JsonProperty]
        public int Team1Score { get; set; }
        [JsonProperty]
        public int Team2Score { get; set; }
        [JsonProperty]
        public int Team3Score { get; set; }
        [JsonProperty]
        public int Team4Score { get; set; }
        [JsonProperty]
        public int Team5Score { get; set; }
        [JsonProperty]
        public int Team6Score { get; set; }
        [JsonProperty]
        public int Team7Score { get; set; }
        [JsonProperty]
        public int Team8Score { get; set; }
        [JsonProperty]
        public int Semi1Score { get; set; }
        [JsonProperty]
        public int Semi2Score { get; set; }
        [JsonProperty]
        public int Semi3Score { get; set; }
        [JsonProperty]
        public int Semi4Score { get; set; }
        [JsonProperty]
        public int Final1Score { get; set; }
        [JsonProperty]
        public int Final2Score { get; set; }
    }
}
