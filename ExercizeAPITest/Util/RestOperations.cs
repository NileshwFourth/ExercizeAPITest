using ExercizeAPITest.DataEntities;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercizeAPITest.Util
{
    public class RestOperations
    {
        public static RestClient ReturnRestClient(String baseURL)
        {
            return new RestClient(baseURL);
        }

        public static RestRequest ReturnPostRequest(string endpoint, int id)
        {
            RestRequest request = new RestRequest(endpoint + $"{id}", Method.GET);
            return request;
        }

        public static IRestResponse ExecuteRequest(RestClient client, RestRequest request)
        {
            IRestResponse response = client.Execute(request);
            return response;
        }

        public static RestRequest ReturnCommentRequest(string endpoint)
        {
            RestRequest request = new RestRequest(endpoint, Method.GET);
            return request;
        }

        public static IRestResponse ExecuteCommentRequest(RestClient client, RestRequest request)
        {
            IRestResponse response = client.Execute<List<Comment>>(request);
            return response;
        }        
    }
}
