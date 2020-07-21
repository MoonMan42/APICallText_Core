using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace APIHelperLibrary
{
    public static class SunProcessor
    {
        public static async Task<SunModel> LoadSunInfo(double lat, double lng)
        {
            string url = $"https://api.sunrise-sunset.org/json?lat={lat}&lng={lng}";


            using (HttpResponseMessage response = await APIHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    SunResultModel sunResult = await response.Content.ReadAsAsync<SunResultModel>();


                    return sunResult.Results;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
