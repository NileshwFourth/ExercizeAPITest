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
        public void PostStatusCodeTestMultipleIds() 
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
        public void PostContentTypeTestFirstId()
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
        public void PostContentTypeTestLastId()
        {
            // arrange
            RestClient client = RestOperations.ReturnRestClient(baseURL);

            RestRequest request = RestOperations.ReturnPostRequest(postsEndPoint, lastId);


            // act                
            IRestResponse response = RestOperations.ExecuteRequest(client, request);

            // assert
            Assert.That(response.ContentType, Is.EqualTo(contentType));

        }

        [Test]
        public void CommentStatusCodeTestMultipleIds()
        {

            for (int idCheck = 1; idCheck <= 100; idCheck = idCheck + 10)
            {
                // arrange
                RestClient client = RestOperations.ReturnRestClient(baseURL);

                string commentEndPoint = postsEndPoint + idCheck + commentsPostsEndPoint;

                RestRequest request = RestOperations.ReturnCommentRequest(commentEndPoint);


                // act                
                IRestResponse response = RestOperations.ExecuteRequest(client, request);

                // assert
                Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            }
        }

        [Test]
        public void CommentContentTypeTestFirstId()
        {
            // arrange
            RestClient client = RestOperations.ReturnRestClient(baseURL);

            string commentEndPoint = postsEndPoint + firstId + commentsPostsEndPoint;

            RestRequest request = RestOperations.ReturnCommentRequest(commentEndPoint);

            // act
            IRestResponse response = RestOperations.ExecuteRequest(client, request);

            // assert
            Assert.That(response.ContentType, Is.EqualTo(contentType));
        }

        [Test]
        public void CommentContentTypeTestLastId()
        {
            // arrange
            RestClient client = RestOperations.ReturnRestClient(baseURL);

            string commentEndPoint = postsEndPoint + lastId + commentsPostsEndPoint;

            RestRequest request = RestOperations.ReturnCommentRequest(commentEndPoint);

            // act
            IRestResponse response = RestOperations.ExecuteRequest(client, request);

            // assert
            Assert.That(response.ContentType, Is.EqualTo(contentType));
        }

    }
}
