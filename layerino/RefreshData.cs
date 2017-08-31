using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace layerino
{
    [JsonObject]
    public class RefreshData
    {
        [JsonProperty]
        public string TeamLeftName { get; set; }
        [JsonProperty]
        public string TeamRightName { get; set; }
        [JsonProperty]
        public int TeamLeftScore { get; set; }
        [JsonProperty]
        public int TeamRightScore { get; set; }
    }
}
