using ExercizeAPITest.DataEntities;
using ExercizeAPITest.Util;
using NUnit.Framework;
using RestSharp;
using RestSharp.Deserializers;
using System.Collections.Generic;

namespace ExercizeAPITest.Tests
{

    [TestFixture]
    public class PostsDeserializationTest : BaseClass
    {
        [Test]
        public void PostsEndPointDeserializationTest()
        {
            // arrange
            
            RestClient client = RestOperations.ReturnRestClient(baseURL);

            RestRequest request = RestOperations.ReturnPostRequest(postsEndPoint, firstId);

            // act
            IRestResponse response = RestOperations.ExecuteRequest(client, request);

            PostsResponse postResponse = DesrializationOperation.PostDeserialize(response);
            
            // assert
            Assert.That(postResponse.ID, Is.EqualTo(firstId));
        }
    }
}
