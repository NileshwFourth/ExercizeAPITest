using Newtonsoft.Json;
using System.Collections.Generic;

namespace ExercizeAPITest.DataEntities
{
    public class Comment
    {
        [JsonProperty("postId")]

        public List<string> PostId { get; set; }

        [JsonProperty("id")]

        public List<string> ID { get; set; }

        [JsonProperty("name")]

        public List<string> Name { get; set; }

        [JsonProperty("email")]

        public List<string> Email { get; set; }

        
        [JsonProperty("body")]
        public List<string> Body { get; set; }
        
    }
}
