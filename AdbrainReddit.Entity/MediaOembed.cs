using Newtonsoft.Json;

namespace AdbrainReddit.Entity
{
    public class MediaOembed :Oembed
    {

        [JsonIgnore]
        public virtual Media Media { get; set; }

    }
}