using System.Net.Http.Json;
using Wraeclib.Models;

namespace Wraeclib.Endpoints;

public class LadderEndpoint {
    readonly HttpClient http;

    internal LadderEndpoint(HttpClient http) => this.http = http;

    /// <param name="realm">Can either be xbox, sony, or poe2. If omitted then the PoE1 PC realm is assumed (optional)</param>
    public async Task<LadderResponse?> GetAsync(string league, int offset = 0, int limit = 50) {
        string url = $"https://www.pathofexile.com/api/ladders/{league}?offset={offset}&limit={limit}";
        return await http.GetFromJsonAsync<LadderResponse>(url);
    }
}