using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using RestSharp;
using System.Windows.Forms;

namespace Windows_Assistant
{
    class IFTTT
    {
        // https://www.youtube.com/watch?v=4uU62-BKa14&list=PL6tu16kXT9PrnRtsbMjadSzrM0f43Nx8W&index=3
        // key for webhooks api call.
        string key;
        
        RestClient client;
        RestRequest request;
        
        public bool executeAction(string trigger)
        {
            request = new RestRequest("{events}/with/key/{key}", Method.POST);
            request.AddUrlSegment("key", key);
            request.AddUrlSegment("events", trigger);
            var content = client.Execute(request).Content;
            return true;
        }

        public bool executeAction(string trigger, string value1)
        {
            request = new RestRequest("{events}/with/key/{key}?value1={value1}", Method.POST);
            request.AddUrlSegment("key", key);
            request.AddUrlSegment("events", trigger);
            request.AddUrlSegment("value1", value1);
            var content = client.Execute(request).Content;
            return true;
        }

        public bool executeAction(string trigger, string value1, string value2)
        {
            request = new RestRequest("{events}/with/key/{key}?value1={value1}&value2={value2}", Method.POST);
            request.AddUrlSegment("key", key);
            request.AddUrlSegment("events", trigger);
            request.AddUrlSegment("value1", value1);
            request.AddUrlSegment("value2", value2);
            var content = client.Execute(request).Content;
            return true;
        }

        public IFTTT (string key, string baseRest)
        {
            this.key = key;
            //baseRestUrl = setKey(key, baseRest);
            client = new RestClient(baseRest);
            //request = new RestRequest("{events}/with/key/{key}", Method.POST);
            //request.AddUrlSegment("key", key);
            
            

            //client.BaseAddress = new Uri(post);
            //HttpResponseMessage response = client.GetAsync()
        }
                     
    }
}
