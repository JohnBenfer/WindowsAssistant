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
        // key for webhooks api call.
        string key = "cQ3xgk9nxLdnmZzs3VkXzv";
        string baseRestUrl;
        string action = "bedroom_lights_on";
        RestClient client;
        RestRequest request;
        
        public bool executeAction(string a)
        {
            setAction(a, baseRestUrl);

            return true;
        }

        private string setAction(string a, string url)
        {
            return url.Replace("event", a);
        }

        private string setKey(string k, string url)
        {
            return url.Replace("webhookskey", k);
        }

        public IFTTT (string key, string baseRest)
        {
            baseRestUrl = setKey(key, baseRest);
            client = new RestClient(baseRestUrl);
            request = new RestRequest("events/{events}", Method.POST);
            MessageBox.Show(request.ToString());
            request.AddUrlSegment("events", "bedroom_lights_off");
            MessageBox.Show(request.ToString());


            //client.BaseAddress = new Uri(post);
            //HttpResponseMessage response = client.GetAsync()
        }
                     
    }
}
