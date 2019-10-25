using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Assistant
{
    public class ApiHelper
    {
        RestClient client;
        RestRequest request;

        public string execute()
        {
            request = new RestRequest("login/v3/oauth?client_id={YOURCLIENTCREDENTIALKEY}&response_type=code&state={TESTSTATE}&scope=playback-control-all&redirect_uri=https%3A%2F%2Facme.example.com%2Flogin%2Ftestclient%2Fauthorized.html", Method.GET);

            return client.Execute(request).Content;
        }

        public ApiHelper(string baseRest)
        {
            client = new RestClient(baseRest);
        }


    }
}
