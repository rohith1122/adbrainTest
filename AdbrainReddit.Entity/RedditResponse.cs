using AdbrainReddit.Repository;
using Newtonsoft.Json;

namespace AdbrainReddit.Entity
{
    public partial class RedditResponse : EntityBase
    {
        

        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }
        
        [JsonProperty(PropertyName = "data")]
        public virtual MainData MainData { get; set; }
        
    }
}
