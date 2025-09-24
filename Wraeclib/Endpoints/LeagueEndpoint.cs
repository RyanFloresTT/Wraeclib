using System.Net.Http.Json;
using Wraeclib.Models;

namespace Wraeclib.Endpoints;
    public class LeaguesEndpoint
    {
        private readonly HttpClient _http;

        internal LeaguesEndpoint(HttpClient http) => _http = http;

        public async Task<IReadOnlyList<League>> GetAsync()
        {
            var response = await _http.GetFromJsonAsync<List<League>>("https://api.pathofexile.com/leagues");
            return response ?? new List<League>();
        }
    }
