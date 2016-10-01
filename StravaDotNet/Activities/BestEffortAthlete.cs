using Newtonsoft.Json;

namespace Strava.Activities
{
    /// <summary>
    /// Athlete for best effort class
    /// <see cref="BestEffort" />
    /// </summary>
    public class BestEffortAthlete
    {
        /// <summary>
        /// Gets or sets athlete id
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}