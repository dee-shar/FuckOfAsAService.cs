using System.Net.Http;
using System.Net.Http.Headers;

namespace FuckOfAsAServiceApi
{
    public class FuckOfAsAService
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://foass.1001010.com/";
        public FuckOfAsAService()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Safari/537.36");
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> GetVersion()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/version");
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetOperations()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/operations");
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetOperationResult(string operationName, string from)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/{operationName}/{from}");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
