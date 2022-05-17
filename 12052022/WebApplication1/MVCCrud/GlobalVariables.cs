using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;

namespace MVCCrud
{
    
    public static class GlobalVariables
    { 
        public static HttpClient WepApiClient = new HttpClient();

        static GlobalVariables()
        {
            WepApiClient.BaseAddress = new Uri("https://localhost:44324/");
            WepApiClient.DefaultRequestHeaders.Clear();
            WepApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        

    }
}