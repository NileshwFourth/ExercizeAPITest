using Newtonsoft.Json;

namespace ExercizeAPITest.DataEntities
{
    public class PostsResponse
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }
}
