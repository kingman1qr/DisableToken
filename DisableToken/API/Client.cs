using System.Net.Http;

//Made by Kingman#9066\\
namespace DisableToken.API
{
    class Client
    {
        public static HttpClient CreateClient(string auth = null, HttpClientHandler handler = null)
        {
            HttpClient client = handler != null ? new HttpClient(handler) : new HttpClient();

            if (auth == "")
            {

            }
            else
            {
                if (auth != null)
                    client.DefaultRequestHeaders.Add("Authorization", auth);
            }
            return client;
        }
    }
}
