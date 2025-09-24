using System.Text.Json.Serialization;

namespace Wraeclib.Models;

public class League
{
    /// <summary>
    /// Unique league ID (used internally by the API).
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;
    
    /// <summary>
    /// Display name of the league (e.g., "Standard", "Hardcore", "Delirium").
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;
    
    /// <summary>
    /// A link to the PoE Page which contains the ladder url.
    /// </summary>
    [JsonPropertyName("url")]
    public string LadderUrl { get; set; } = null!;

    /// <summary>
    /// What platform this realm is on (e.g., "PC").
    /// </summary>
    [JsonPropertyName("realm")]
    public string Realm { get; set; } = null!;

    /// <summary>
    /// Description of the league.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; } = null!;

    /// <summary>
    /// Whether this league is currently active.
    /// </summary>
    [JsonPropertyName("active")]
    public bool Active { get; set; }

    /// <summary>
    /// The date the league started.
    /// </summary>
    [JsonPropertyName("startAt")]
    public DateTime? StartAt { get; set; }

    /// <summary>
    /// The date the league ends (if temporary league).
    /// </summary>
    [JsonPropertyName("endAt")]
    public DateTime? EndAt { get; set; }
}