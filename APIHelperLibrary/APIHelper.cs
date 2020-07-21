using System.Net.Http;
using System.Net.Http.Headers;

namespace APIHelperLibrary
{

    // install Microsoft.AspNet.WebApi.Client package and Newtonsoft.Json
    public static class APIHelper
    {
        public static HttpClient ApiClient { get; set; }

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            //ApiClient.BaseAddress = new Uri("http://xkcd.com/info.0.json ");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
