***POTENTIAL FEATURES***
1. Improved error handling. While the current endpoint returns an error response to invalid requests, 
   it would be more beneficial to users if this functionality was expanded to provide better information 
   as to why the error happened.
   
2. Implement a simple database to save a history of requests sent. Users may want to retrieve payloads sent 
   previously, which is not currently possible, as nothing is being saved.
   
3. Expand functionality from replace "dog" with "cat" to replace <string1> with <string2>. While the current 
   implementation is not particularily useful to anyone; tools that replace all instances of a keyword in a body
   of text are useful. That feature exists in many text editors. If I was tasked with transforming this endpoint
   into a useful tool, this is the first step I would take.

***POTENTIAL TEST CASES***
1. Basic test case: Send a simple JSON payload. e.g. { "test" : "functioning"} to check that the endpoint is online.

2. Positive test case: send a simple JSON payload e.g. { "cat" : "dog "} to check if the endpoint is correctly replacing instances of "dog" with "cat". 
   confirm by checking against expected output e.g. { "cat" : "cat" }
   
3. failure test case: send an incorrectly formatted JSON payload to ensure the endpoint correctly returns errors. 
   confirm by checking that the response to the payload is not success
   
4. syntax test case: send a JSON payload with varying syntax to ensure only exact "dog" instances are changed. e.g. { "exact" : "dog", "inexact" : "dOg" }.
   confirm by checking against expected output e.g. { "exact" : "cat", "inexact": dOg}
