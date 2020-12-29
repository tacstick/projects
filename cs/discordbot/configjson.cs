using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace cs
{
    public struct ConfigJson
    {
        [JsonProperty("token")]
        public string token { get; private set; }
        [JsonProperty("prefix")]
        public string prefix { get; private set; }
        [JsonProperty("overlordtoken")]
        public string overlordtoken { get; private set; }
        [JsonProperty("overlordprefix")]
        public string overlordprefix { get; private set; }
    }
}
