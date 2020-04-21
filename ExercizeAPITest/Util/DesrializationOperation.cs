using ExercizeAPITest.DataEntities;
using RestSharp;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercizeAPITest.Util
{
    public static class DesrializationOperation
    {
        public static PostsResponse PostDeserialize(IRestResponse response)
        {
            PostsResponse postResponse = new JsonDeserializer().Deserialize<PostsResponse>(response);
            return postResponse;
        }

        public static List<Comment> CommentDeserialize(IRestResponse response)
        {
            RestSharp.Deserializers.JsonDeserializer deserial = new RestSharp.Deserializers.JsonDeserializer();
            var commentObject = deserial.Deserialize<List<Comment>>(response);
            return commentObject;
        }
    }
}
