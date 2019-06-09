namespace ChuckNorris
{
    using System.Net;
    using Newtonsoft.Json;

    public class ChuckNorrisLogic
    {
        public string Type { get; set; } = string.Empty;

        public ChuckNorrisData Value { get; set; } = new ChuckNorrisData();

        private const string k_UrlPath = "http://api.icndb.com/jokes/random/";

        public static string GenerateChuckNorrisJoke()
        {
            string json = null;
            ChuckNorrisLogic chuck;

            try
            {
                using (WebClient client = new WebClient())
                {
                    json = client.DownloadString(k_UrlPath);
                }

                chuck = JsonConvert.DeserializeObject<ChuckNorrisLogic>(json);
                chuck.Value.Joke = chuck.Value.Joke.Replace("&quot;", "\"");
            }
            catch
            {
                chuck = new ChuckNorrisLogic();
            }
            
            return chuck.Value.Joke;
        }
    }
}
