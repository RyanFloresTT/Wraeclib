namespace Wraeclib;

public class WraeclibBuilder
{
    private string? _userAgent;
    private string? _oauthToken;
    private HttpMessageHandler? _httpHandler;
    private TimeSpan? _timeout;

    private WraeclibBuilder() { }

    public static WraeclibBuilder Create() => new WraeclibBuilder();

    /// <summary>
    /// Require consumer to supply User-Agent for all requests.
    /// </summary>
    public WraeclibBuilder WithUserAgent(string userAgent)
    {
        _userAgent = userAgent ?? throw new ArgumentNullException(nameof(userAgent));
        return this;
    }

    public WraeclibBuilder WithOAuthToken(string token)
    {
        _oauthToken = token;
        return this;
    }

    public WraeclibBuilder WithHandler(HttpMessageHandler handler)
    {
        _httpHandler = handler;
        return this;
    }

    public WraeclibBuilder WithTimeout(TimeSpan timeout)
    {
        _timeout = timeout;
        return this;
    }

    public WraeclibClient Build()
    {
        if (string.IsNullOrWhiteSpace(_userAgent))
            throw new InvalidOperationException("User-Agent is required. Use WithUserAgent().");

        var httpClient = _httpHandler is null ? new HttpClient() : new HttpClient(_httpHandler);

        // Set required User-Agent
        httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(_userAgent);

        // Optional Authorization
        if (!string.IsNullOrWhiteSpace(_oauthToken))
            httpClient.DefaultRequestHeaders.Authorization = 
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _oauthToken);

        if (_timeout.HasValue)
            httpClient.Timeout = _timeout.Value;

        return new WraeclibClient(httpClient);
    }
}