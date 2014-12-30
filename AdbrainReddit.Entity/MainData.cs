using System.Collections.Generic;
using AdbrainReddit.Repository;
using Newtonsoft.Json;

namespace AdbrainReddit.Entity
{
    public partial class MainData : EntityBase
    {
        

        [JsonProperty(PropertyName = "modhash")]
        public string Modhash { get; set; }


        [JsonProperty(PropertyName = "after")]
        public string After { get; set; }

        [JsonProperty(PropertyName = "before")]
        public string Before { get; set; }

        [JsonProperty(PropertyName = "children")]
        public virtual List<Child> Children { get; set; }


        // Navigation Properties
        [JsonIgnore]
        public virtual RedditResponse RedditResponse { get; set; }



    }
}
