using NUnit.Framework;
using RestSharp;
using System.Net;
using ExercizeAPITest.DataEntities;
using ExercizeAPITest.Util;

namespace ExercizeAPITest.Tests
{
    [TestFixture]
    public class CommentDataDrivenTests : BaseClass
    {
        [TestCase("1", HttpStatusCode.OK, TestName = "Check comment status code for id 1")]
        [TestCase("10", HttpStatusCode.OK, TestName = "Check comment status code for id 10")]
        [TestCase("20", HttpStatusCode.OK, TestName = "Check comment status code for id 20")]
        [TestCase("30", HttpStatusCode.OK, TestName = "Check comment status code for id 30")]
        [TestCase("40", HttpStatusCode.OK, TestName = "Check comment status code for id 40")]
        [TestCase("50", HttpStatusCode.OK, TestName = "Check comment status code for id 50")]
        [TestCase("60", HttpStatusCode.OK, TestName = "Check comment status code for id 60")]
        [TestCase("70", HttpStatusCode.OK, TestName = "Check comment status code for id 70")]
        [TestCase("80", HttpStatusCode.OK, TestName = "Check comment status code for id 80")]
        [TestCase("90", HttpStatusCode.OK, TestName = "Check comment status code for id 90")]
        [TestCase("99", HttpStatusCode.OK, TestName = "Check comment status code for id 99")]
        [TestCase("100", HttpStatusCode.OK, TestName = "Check comment status code for id 100")]
        //Negative Test Data:
        [TestCase("101", HttpStatusCode.NotFound, TestName = "Check comment status code for id 101")]
        [TestCase("110", HttpStatusCode.NotFound, TestName = "Check comment status code for id 110")]
        [TestCase("200", HttpStatusCode.NotFound, TestName = "Check comment status code for id 200")]
        public void StatusCodeTest(string id, HttpStatusCode expectedHttpStatusCode)
        {
            // arrange
            
            RestClient client = RestOperations.ReturnRestClient(baseURL);

            string commentEndPoint = postsEndPoint + id + commentsEndPoint;

            RestRequest request = RestOperations.ReturnCommentRequest(commentEndPoint);


            // act
            
            IRestResponse response = RestOperations.ExecuteRequest(client, request);

            // assert
            Assert.That(response.StatusCode, Is.EqualTo(expectedHttpStatusCode));            
        }
    }
}
