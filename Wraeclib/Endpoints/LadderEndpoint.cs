using System.Net.Http.Json;
using Wraeclib.Models;

namespace Wraeclib.Endpoints;

public class LadderEndpoint
{
    private readonly HttpClient _http;

    internal LadderEndpoint(HttpClient http) => _http = http;

    /// <summary>
    /// Fetches ladder entries for a given league.
    /// </summary>
    public async Task<LadderResponse> GetAsync(string league, int offset = 0, int limit = 50)
    {
        var url = $"https://www.pathofexile.com/api/ladders/{league}?offset={offset}&limit={limit}";
        return await _http.GetFromJsonAsync<LadderResponse>(url)
               ?? new LadderResponse { Total = 0, Entries = [] };
    }
}