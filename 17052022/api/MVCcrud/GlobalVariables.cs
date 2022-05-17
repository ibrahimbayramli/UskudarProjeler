using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace MVCcrud
{
    public static class GlobalVariables
    {
        public static HttpClient WepApiClient = new HttpClient();

        static GlobalVariables()
        {
            WepApiClient.BaseAddress = new Uri("https://localhost:44326/api");
            WepApiClient.DefaultRequestHeaders.Clear();
            WepApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

    }
}