using System;
using System.Net.Http;
using System.Runtime.InteropServices.Marshalling;
using System.Text.Json;
using System.Threading.Tasks;

namespace Project_R.Server.Controllers
{
    public class WeatherCall
    {
        private static string apiKey = "1bc7db29743fe4b65e67ebb004148d77";

        public static async Task<WeatherResponse> GetWeatherAsync(string city, string countryCode)
        {
            string apiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city},{countryCode}&appid={apiKey}&units=metric";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    WeatherResponse weatherResponse = JsonSerializer.Deserialize<WeatherResponse>(jsonResponse, new JsonSerializerOptions { PropertyNameCaseInsensitive = true});

                    return weatherResponse;
                }
                else
                {
                    throw new Exception("Failed to retrieve weather data.");
                }
            }
        }
    }
}
