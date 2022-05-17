using System.Net.Http;


namespace mvcCrud
{
    public class GlobalVariables
    {
        public static HttpClient WebApiClient = new HttpClient();

        static GlobalVariables()
        {


            WebApiClient.BaseAddress = new System.Uri("https://localhost:44393/api/");

            WebApiClient.DefaultRequestHeaders.Clear();
            WebApiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));






        }


    }
}