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
        public static PostsResponse Deserialize(IRestResponse response)
        {
            PostsResponse postResponse = new JsonDeserializer().Deserialize<PostsResponse>(response);
            return postResponse;
        }
    }
}
