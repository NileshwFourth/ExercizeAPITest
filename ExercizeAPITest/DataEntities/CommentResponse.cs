using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExercizeAPITest.DataEntities
{
    public class CommentResponse
    {
        [JsonProperty("comments")]
        public List<Comment> Comments { get; set; }       
    }
}
