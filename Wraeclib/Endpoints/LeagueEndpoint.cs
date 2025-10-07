using System.Net.Http.Json;
using Wraeclib.Models;

namespace Wraeclib.Endpoints;
public class LeaguesEndpoint {
    readonly HttpClient http;

    internal LeaguesEndpoint(HttpClient http) => this.http = http;

    /// <param name="realm">Can either be xbox, sony, or poe2. If omitted then the PoE1 PC realm is assumed (optional)</param>
    public async Task<IReadOnlyList<League>?> GetAllAsync(string realm = "PC", int offset = 0, int limit = 50) {
        return await http.GetFromJsonAsync<List<League>>($"https://api.pathofexile.com/leagues?realm={realm}&offset={offset}&limit={limit}");
    }
}