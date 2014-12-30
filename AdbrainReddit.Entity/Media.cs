using System;
using System.Collections.Generic;
using AdbrainReddit.Repository;
using Newtonsoft.Json;

namespace AdbrainReddit.Entity
{
    public partial class Media : EntityBase
    {
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "oembed")]
        public MediaOembed MediaOembed { get; set; }

        [JsonIgnore]
        public virtual Data Data { get; set; }
    }
}
