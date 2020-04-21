using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercizeAPITest.DataEntities
{
    public class BaseClass
    {
        public readonly string baseURL = "https://jsonplaceholder.typicode.com/";
        public readonly string postsEndPoint = "/posts/";
        public readonly string commentsEndPoint = "/comments";
        public readonly int firstId = 1;
        public readonly string contentType = "application/json; charset=utf-8";
    }
}
