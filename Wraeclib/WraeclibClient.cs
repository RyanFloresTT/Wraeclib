
using Wraeclib.Endpoints;

namespace Wraeclib
{
    public class WraeclibClient
    {
        private readonly HttpClient _http;

        internal WraeclibClient(HttpClient http)
        {
            _http = http ?? throw new ArgumentNullException(nameof(http));

            // Initialize endpoints
            Leagues = new LeaguesEndpoint(_http);
            // Characters = new CharactersEndpoint(_http);
            Ladder = new LadderEndpoint(http);
        }

        /// <summary>
        /// Access Path of Exile leagues.
        /// </summary>
        public LeaguesEndpoint Leagues { get; }

        /// <summary>
        /// Access character-related endpoints.
        /// </summary>
        // public CharactersEndpoint Characters { get; }
        
        /// <summary>
        /// Access Path of Exile ladders.
        /// </summary>
        public LadderEndpoint Ladder { get; }
    }
}