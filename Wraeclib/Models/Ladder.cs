using System.Text.Json.Serialization;

namespace Wraeclib.Models;

public class LadderEntry
{
    [JsonPropertyName("rank")]
    public int Rank { get; set; }

    [JsonPropertyName("account")]
    public LadderAccount Account { get; set; } = null!;

    [JsonPropertyName("character")]
    public LadderCharacter Character { get; set; } = null!;
}

public class LadderAccount
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;
        
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;
}

public class LadderCharacter
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;
        
    [JsonPropertyName("level")]
    public int Level { get; set; }
        
    [JsonPropertyName("class")]
    public string Class { get; set; } = null!;
}
public class LadderResponse
{
    [JsonPropertyName("total")]
    public int Total { get; set; }

    [JsonPropertyName("entries")]
    public LadderEntry[] Entries { get; set; } = null!;
}