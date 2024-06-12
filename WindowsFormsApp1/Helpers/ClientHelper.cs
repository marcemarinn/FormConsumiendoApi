using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Helpers
{
    public static class ClientHelper
    {
        private static HttpClient _client = new HttpClient();

        public static async Task<T> Get<T>(string url)
        {
            //https://rickandmortyapi.com/api/character
            try
            {
                HttpResponseMessage response = await
                    _client.GetAsync(url);

                response.EnsureSuccessStatusCode();

                string responseJson =
                    await response.Content.ReadAsStringAsync();


                var result = JsonConvert.DeserializeObject<T>(responseJson);

                return result;
            }

            catch (Exception ex)
            {
                throw new Exception($"Error al obtener los personajes: {ex.Message}");
            }
        }
    }
}
