using Newtonsoft.Json;

namespace AdbrainReddit.Entity
{
    public class SecureMediaOembed : Oembed
    {
        [JsonIgnore]
        public virtual SecureMedia SecureMedia { get; set; }
 
    }
}