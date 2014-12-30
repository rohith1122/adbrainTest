using System;
using System.Collections.Generic;
using AdbrainReddit.Repository;
using Newtonsoft.Json;

namespace AdbrainReddit.Entity
{
    public partial class MediaEmbed : EntityBase
    {

        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

        [JsonProperty(PropertyName = "width")]
        public int? Width { get; set; }

        [JsonProperty(PropertyName = "scrolling")]
        public bool? Scrolling { get; set; }

        [JsonProperty(PropertyName = "height")]
        public int? Height { get; set; }

        [JsonIgnore]
        public virtual Data Data { get; set; }

    }
}
