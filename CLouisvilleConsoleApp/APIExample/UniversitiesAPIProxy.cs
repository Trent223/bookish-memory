using System.Text.Json;

namespace APIExample
{
    internal class UniversitiesAPIProxy
    {
        private readonly string _baseUrl = "http://universities.hipolabs.com/";
        private readonly HttpClient _client;

        public UniversitiesAPIProxy()
        {
            _client = new()
            {
                BaseAddress = new Uri(_baseUrl)
            };
        }

        public async Task<string> SearchByNameAsync(string name)
        {
            var response = await _client.GetAsync($"search?name={name}");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> SearchByNameAndCountryAsync(string name, string country)
        {
            var response = await _client.GetAsync($"search?name={name}&country={country}");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<List<University>> SearchByNameAsUniversityAsync(string name)
        {
            var response = await _client.GetAsync($"search?name={name}");
            string responseBody = await response.Content.ReadAsStringAsync();

            JsonSerializerOptions options = new()
            {
                PropertyNameCaseInsensitive = true,
            };
            return JsonSerializer.Deserialize<List<University>>(responseBody, options);
        }
    }
}
