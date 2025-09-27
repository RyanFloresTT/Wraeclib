# Wraeclib

A .NET client library for interacting with the Path of Exile API. This library provides a clean, strongly-typed interface for accessing league information, ladder data, and other PoE-related endpoints. Wraeclib is designed to support both Path of Exile and Path of Exile 2 once the API becomes available.

## Installation

Wraeclib ***will*** be available as a NuGet package. Install it using your preferred method:

```bash
dotnet add package Wraeclib
```

Or via Package Manager:
```
Install-Package Wraeclib
```

## Requirements

## Requirements

- .NET 9.0 or later  
- A valid User-Agent string (required by GGG's API policy)  
- An OAuth token issued by GGG if you need to access authenticated endpoints  
  ([details here](https://www.pathofexile.com/developer/docs/authorization))

## Quick Start

```csharp
using Wraeclib;

// Create a client instance
var client = WraeclibBuilder.Create()
    .WithUserAgent("YourAppName/1.0")
    .Build();

// Get available leagues
var leagues = await client.Leagues.GetAsync();
foreach (var league in leagues)
{
    Console.WriteLine($"{league.Name} - {league.Description}");
}

// Get ladder data for a specific league
var ladder = await client.Ladder.GetAsync("Standard", offset: 0, limit: 10);
Console.WriteLine($"Total ladder entries: {ladder.Total}");
foreach (var entry in ladder.Entries)
{
    Console.WriteLine($"{entry.Rank}: {entry.Character.Name} ({entry.Character.Class}) - Level {entry.Character.Level}");
}
```

## Configuration

### Builder Pattern

Wraeclib uses a builder pattern for configuration. All configuration is done through the `WraeclibBuilder` class:

```csharp
var client = WraeclibBuilder.Create()
    .WithUserAgent("YourAppName/1.0")           // Required
    .WithOAuthToken("your-oauth-token")         // Optional, for authenticated requests
    .WithTimeout(TimeSpan.FromSeconds(30))      // Optional, default timeout
    .WithHandler(customHttpHandler)             // Optional, custom HTTP handler
    .Build();
```

### Configuration Options

- **User-Agent** (Required): A string identifying your application. GGG requires this for all API requests.
- **OAuth Token** (Optional): For authenticated requests when available.
- **Timeout** (Optional): HTTP client timeout duration.
- **Handler** (Optional): Custom `HttpMessageHandler` for advanced scenarios like proxies or custom authentication.

## Available Endpoints

### Leagues

Access information about Path of Exile leagues:

```csharp
var leagues = await client.Leagues.GetAsync();

foreach (var league in leagues)
{
    Console.WriteLine($"League: {league.Name}");
    Console.WriteLine($"Active: {league.Active}");
    Console.WriteLine($"Realm: {league.Realm}");
    Console.WriteLine($"Start Date: {league.StartAt}");
}
```

### Ladder

Retrieve ladder/leaderboard data for specific leagues:

```csharp
// Get top 50 players from Standard league
var ladder = await client.Ladder.GetAsync("Standard", offset: 0, limit: 50);

// Get players ranked 51-100
var nextPage = await client.Ladder.GetAsync("Standard", offset: 50, limit: 50);
```

## Data Models

### League

```csharp
public class League
{
    public string Id { get; set; }           // Unique league identifier
    public string Name { get; set; }         // Display name (e.g., "Standard", "Hardcore")
    public string LadderUrl { get; set; }    // URL to league ladder page
    public string Realm { get; set; }        // Platform (e.g., "PC")
    public string Description { get; set; }  // League description
    public bool Active { get; set; }         // Whether league is currently active
    public DateTime? StartAt { get; set; }   // League start date
    public DateTime? EndAt { get; set; }     // League end date (for temporary leagues)
}
```

### Ladder

```csharp
public class LadderResponse
{
    public int Total { get; set; }           // Total number of entries in ladder
    public LadderEntry[] Entries { get; set; } // Array of ladder entries
}

public class LadderEntry
{
    public int Rank { get; set; }            // Player's rank in ladder
    public LadderAccount Account { get; set; } // Account information
    public LadderCharacter Character { get; set; } // Character information
}
```

## Error Handling

Wraeclib uses standard .NET exception handling. Common scenarios to handle:

```csharp
try
{
    var leagues = await client.Leagues.GetAsync();
}
catch (HttpRequestException ex)
{
    // Handle network/HTTP errors
    Console.WriteLine($"HTTP Error: {ex.Message}");
}
catch (TaskCanceledException ex)
{
    // Handle timeout errors
    Console.WriteLine($"Request timed out: {ex.Message}");
}
catch (JsonException ex)
{
    // Handle JSON parsing errors
    Console.WriteLine($"JSON parsing error: {ex.Message}");
}
```

## Development Status

This library is currently in development and not all planned features are implemented yet. The current implementation includes:

- ✅ League information retrieval
- ✅ Ladder/leaderboard data
- ✅ Basic HTTP client configuration

### Planned Features

- Character information and statistics
- Item data and pricing
- Account and profile management
- Path of Exile 2 support (when API becomes available)

## Contributing

This project is under active development. Contributions are welcome, but please note that the library is still evolving and the API may change.

## Disclaimer

This library is not affiliated with Grinding Gear Games. Path of Exile is a trademark of Grinding Gear Games. Please respect GGG's API terms of service and rate limits when using this library.
