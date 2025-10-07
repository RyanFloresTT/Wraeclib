namespace Wraeclib;

public class WraeclibBuilder {
    string? userAgent;
    string? oauthToken;
    HttpMessageHandler? httpHandler;
    TimeSpan? timeout;

    WraeclibBuilder() { }

    public static WraeclibBuilder Create() => new WraeclibBuilder();

    /// <summary>
    /// Require consumer to supply User-Agent for all requests.
    /// </summary>
    public WraeclibBuilder WithUserAgent(string userAgent) {
        this.userAgent = userAgent ?? throw new ArgumentNullException(nameof(userAgent));
        return this;
    }

    public WraeclibBuilder WithOAuthToken(string token) {
        oauthToken = token;
        return this;
    }

    public WraeclibBuilder WithHandler(HttpMessageHandler handler) {
        httpHandler = handler;
        return this;
    }

    public WraeclibBuilder WithTimeout(TimeSpan timeout) {
        this.timeout = timeout;
        return this;
    }

    public WraeclibClient Build() {
        if (string.IsNullOrWhiteSpace(userAgent))
            throw new InvalidOperationException("User-Agent is required. Use WithUserAgent().");

        var httpClient = httpHandler is null ? new HttpClient() : new HttpClient(httpHandler);

        httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(userAgent);

        if (!string.IsNullOrWhiteSpace(oauthToken))
            httpClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", oauthToken);

        if (timeout.HasValue)
            httpClient.Timeout = timeout.Value;

        return new WraeclibClient(httpClient);
    }
}