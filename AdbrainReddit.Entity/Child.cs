using AdbrainReddit.Repository;
using Newtonsoft.Json;

namespace AdbrainReddit.Entity
{
    public  class Child :EntityBase
    {
        
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }


        [JsonProperty(PropertyName = "data")]
        public virtual Data Data { get; set; }
        [JsonIgnore]
        public int MainDataId { get; set; }
        [JsonIgnore]
        public virtual MainData MainData { get; set; }

    }
}
