using System;
using Newtonsoft.Json;

namespace AdbrainReddit.Services.ViewModels
{
    public class ItemVm
    {
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "permalink")]
        public string PermaLink { get; set; }

        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }






    }
}
