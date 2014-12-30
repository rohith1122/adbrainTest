
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AdbrainReddit.Services.ViewModels
{
    public class AuthorVm
    {
        [JsonProperty(PropertyName = "author")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "items")]
        public IList<ItemVm> Items { get; set; }
    }
}
