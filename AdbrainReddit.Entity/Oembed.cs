using AdbrainReddit.Repository;
using Newtonsoft.Json;

namespace AdbrainReddit.Entity
{
    public class Oembed :EntityBase
    {
        [JsonProperty(PropertyName = "provider_url")]
        public string ProviderUrl { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "author_name")]
        public string AuthorName { get; set; }

        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; }

        [JsonProperty(PropertyName = "width")]
        public int Width { get; set; }

        [JsonProperty(PropertyName = "html")]
        public string Html { get; set; }

        [JsonProperty(PropertyName = "thumbnail_width")]
        public int ThumbnailWidth { get; set; }

        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        [JsonProperty(PropertyName = "provider_name")]
        public string ProviderName { get; set; }

        [JsonProperty(PropertyName = "thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "thumbnail_height")]
        public int ThumbnailHeight { get; set; }

        [JsonProperty(PropertyName = "author_url")]
        public string AuthorUrl { get; set; }

        

      



    }
}
