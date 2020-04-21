using NUnit.Framework;
using RestSharp;
using System.Net;
using ExercizeAPITest.DataEntities;
using ExercizeAPITest.Util;

namespace ExercizeAPITest.Tests
{
    [TestFixture]
    public class BasicTests : BaseClass
    {
        [Test]
        public void PostStatusCodeTest() 
        {
            
            for (int idCheck = 1; idCheck <= 100; idCheck=idCheck+10)
            {
                // arrange
                RestClient client = RestOperations.ReturnRestClient(baseURL);

                RestRequest request = RestOperations.ReturnPostRequest(postsEndPoint, idCheck);
                

                // act                
                IRestResponse response = RestOperations.ExecuteRequest(client, request);

                // assert
                Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            }
        }

        [Test]
        public void PostContentTypeTest()
        {            
                // arrange
                RestClient client = RestOperations.ReturnRestClient(baseURL);

                RestRequest request = RestOperations.ReturnPostRequest(postsEndPoint, firstId);


                // act                
                IRestResponse response = RestOperations.ExecuteRequest(client, request);

                // assert
                Assert.That(response.ContentType, Is.EqualTo(contentType));
            
        }

        [Test]
        public void CommentStatusCodeTest()
        {

            for (int idCheck = 1; idCheck <= 100; idCheck = idCheck + 10)
            {
                // arrange
                RestClient client = RestOperations.ReturnRestClient(baseURL);

                string commentEndPoint = postsEndPoint + idCheck + commentsEndPoint;

                RestRequest request = RestOperations.ReturnCommentRequest(commentEndPoint);


                // act                
                IRestResponse response = RestOperations.ExecuteRequest(client, request);

                // assert
                Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            }
        }

        [Test]
        public void CommentContentTypeTest()
        {
            // arrange
            RestClient client = RestOperations.ReturnRestClient(baseURL);

            string commentEndPoint = postsEndPoint + firstId + commentsEndPoint;

            RestRequest request = RestOperations.ReturnCommentRequest(commentEndPoint);

            // act
            IRestResponse response = RestOperations.ExecuteRequest(client, request);

            // assert
            Assert.That(response.ContentType, Is.EqualTo(contentType));
        }
    }
}
