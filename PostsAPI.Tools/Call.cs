using System.Text.Json;
namespace PostsAPI.Tools
{
    public class Call
    {
        /// <summary>
        /// Classe permettant de faire un call API

        public string GetDataFromApi(string url)

        {
            string result = "";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            //Appel de l'API et récupération de la réponse
            result = client.GetStringAsync(url).Result;
            return result;
        }

        /// <summary>
        /// /// récuêrer un post de l'API
        /// /// </summary>
        ///<param name="url">api endpoint</param>
        ////// <returns></returns>
        public Posts GetPosts(string url)
        {
            Posts result = new Posts();


            var jsonFlux = GetDataFromApi(url);
            var json = JsonSerializer.Deserialize<Posts>(jsonFlux);

            result.id = json.id;
            result.title = json.title;
            result.body = json.body;

            return result;
        }
    }
}
