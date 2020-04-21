JSON Placeholder API Test

This automation framework is to test the GET Request of follwoing endpoints:

Posts https://jsonplaceholder.typicode.com/posts/1

Comments https://jsonplaceholder.typicode.com/comments/1

The framework uses RestSharp library for testing. 

Report of findings :
There were 38 testcases of which 5 negative testcases for comment have failed result. 

The api endpoint is not working correctly for comment end points when the invalid id's are sent. 
The response status code is 200 OK with empty response body.

Taking this into consideration it is major defect 
Testing can't be signed off unless this defect is resolved.

TESTING RESULT : FAIL
