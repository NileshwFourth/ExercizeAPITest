using ExercizeAPITest.DataEntities;
using ExercizeAPITest.Util;
using NUnit.Framework;
using RestSharp;
using RestSharp.Deserializers;
using System.Collections.Generic;

namespace ExercizeAPITest.Tests
{
    [TestFixture]
    public class DeserializationTests : BaseClass
    {
        [Test]
        public void PostsSerializationTest()
        {
            // arrange
            
            RestClient client = RestOperations.ReturnRestClient(baseURL);

            RestRequest request = RestOperations.ReturnPostRequest(postsEndPoint, firstId);

            // act
            IRestResponse response = RestOperations.ExecuteRequest(client, request);

            PostsResponse postResponse = DesrializationOperation.Deserialize(response);
            
            // assert
            Assert.That(postResponse.ID, Is.EqualTo(firstId));
        }

        [Test]
        public void CommentSerializationTest()
        {
            // arrange
            RestClient client = RestOperations.ReturnRestClient(baseURL);

            string commentEndPoint = postsEndPoint + firstId + commentsEndPoint;

            RestRequest request = RestOperations.ReturnCommentRequest(commentEndPoint);

            // act
            var response = client.Execute<List<Comment>>(request);
            //IRestResponse response = client.Execute<List<Comment>>(request);
            //IRestResponse response = client.Execute(request);

            //Comment comment = new JsonDeserializer().Deserialize<Comment>(response);

              RestSharp.Deserializers.JsonDeserializer deserial = new RestSharp.Deserializers.JsonDeserializer();
              var rootObject = deserial.Deserialize<List<Comment>>(response);
            //var newrootObject = deserial.Deserialize<Comment>(rootObject);
                        
            // assert
            foreach (Comment obj in rootObject)
            { 
                Assert.That(obj.ID[0], Is.EqualTo("1"));
                break;
            }
        }
    }
}
