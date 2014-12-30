using System;
using System.Collections.Generic;
using AdbrainReddit.Repository;
using Newtonsoft.Json;

namespace AdbrainReddit.Entity
{
    public partial class SecureMedia : EntityBase
    {
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "oembed")]
        public SecureMediaOembed SecureMediaOembed { get; set; }

        [JsonIgnore]
        public virtual Data Data { get; set; }

    }
}
