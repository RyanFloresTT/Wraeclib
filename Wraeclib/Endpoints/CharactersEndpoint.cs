using Wraeclib.Models;
using System.Net.Http.Json;

namespace Wraeclib.Endpoints;

public class CharactersEndpoint {
    readonly HttpClient http;

    internal CharactersEndpoint(HttpClient http) => this.http = http;

    /// <param name="realm">Can either be xbox, sony, or poe2. If omitted then the PoE1 PC realm is assumed (optional)</param>
    /// <returns></returns>
    public async Task<List<Character>?> GetAllAsync(string realm = "PC", int offset = 0, int limit = 50) {
        string url = $"https://www.pathofexile.com/api/character/{realm}?offset={offset}&limit={limit}";
        return await http.GetFromJsonAsync<List<Character>>(url);
    }

    public async Task<Character?> GetByNameAsync(string name, string realm = "PC") {
        string url = $"https://www.pathofexile.com/api/character/{realm}/{name}";
        return await http.GetFromJsonAsync<Character>(url);
    }
}