
using System.ComponentModel.DataAnnotations.Schema;

namespace AdbrainReddit.Repository
{
    public interface IObjectState
    {
        [NotMapped]
        ObjectState State { get; set; }
    }
}