using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace AdbrainReddit.Repository
{
    public abstract class EntityBase : IObjectState
    {


        [JsonIgnore]
        public int UId { get; set; }


        [NotMapped]
        [JsonIgnore]
        public ObjectState State { get; set; }
    }
}