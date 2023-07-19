using Reddit;
using Reddit.AuthTokenRetriever;
using Reddit.AuthTokenRetriever.EventArgs;
using System.Diagnostics;
using System.Runtime.InteropServices;

var redditClient = new RedditClient(
    appId: "MM1cXMwnFzl1jfdcS6tlYQ", 
    appSecret: "DL2udSauuJ3cwtPFKOF7hZEOJ2DApQ", 
    accessToken: "eyJhbGciOiJSUzI1NiIsImtpZCI6IlNIQTI1NjpzS3dsMnlsV0VtMjVmcXhwTU40cWY4MXE2OWFFdWFyMnpLMUdhVGxjdWNZIiwidHlwIjoiSldUIn0.eyJzdWIiOiJsb2lkIiwiZXhwIjoxNjg4MDQzNTQwLjQzMjAzNSwiaWF0IjoxNjg3OTU3MTQwLjQzMjAzNCwianRpIjoiQ2hvNk1ZWFlwZ3FxSVJ5YWJ6NjdXbzFObTk1TlhnIiwiY2lkIjoiMFJ5MVRhS0dGTHRQNVEiLCJsaWQiOiJ0Ml9lY3N1dWJxZGQiLCJsY2EiOjE2ODc5NTcxNDA0MzEsInNjcCI6ImVKeUtWdEpTaWdVRUFBRF9fd056QVNjIiwiZmxvIjo2fQ.FPGV6Z3zwEkbYFw1Kbo8CZDgudj3Zw-fKu749hw0aQSXw1DfCFv9f4_cnmy_RrawyxAwFpec3dnJuZ0SIGIOZp7ha7bTYyqrD5aL_qFs9Dqyak7RMhwBwHm_lhIYIvQ_qQkP1fW_BtIvPKDcGNRkV3Q9NH8iDeyUPQLjAjQYeQEpRxDnpc9usxcSIZdD7s521yOPRwqa2roK8GV85-s1kKeM0Gh2zX94v-E4UvsvqUuL5QJnFnE_RCI41uqT8MmCL0NtAzpAr7628LHt265UX47qJwoQLb02TlhjRRmmMV4YfQGYxP6Vcd7-YgM9g8Bt6i_XTxtVRLjvEPg2G_LR_A");
//Get One Hour Accses Token https://not-an-aardvark.github.io/reddit-oauth-helper/;
var truerateme = redditClient.Subreddit("truerateme");
var top100poset = truerateme.Posts.GetTop();

foreach (var x in top100poset)
{
    Console.WriteLine(x.Info());
}