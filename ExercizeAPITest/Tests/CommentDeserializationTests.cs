using ExercizeAPITest.DataEntities;
using ExercizeAPITest.Util;
using NUnit.Framework;
using RestSharp;
using RestSharp.Deserializers;
using System.Collections.Generic;

namespace ExercizeAPITest.Tests
{
    [TestFixture]
    public class CommentDeserializationTests : BaseClass
    {
        [Test]
        public void CommentEndPointDeserializationTests()
        {
            // arrange
            RestClient client = RestOperations.ReturnRestClient(baseURL);

            string commentEndPoint = postsEndPoint + firstId + commentsEndPoint;

            RestRequest request = RestOperations.ReturnCommentRequest(commentEndPoint);

            // act            
            var response = RestOperations.ExecuteCommentRequest(client, request);

            var commentObject = DesrializationOperation.CommentDeserialize(response);
                                    
            // assert
            foreach (Comment obj in commentObject)
            { 
                Assert.That(obj.ID[0], Is.EqualTo(firstId));
                break;
            }
        }
    }
}
