using Newtonsoft.Json;

namespace Strava.Activities
{
    /// <summary>
    /// Activity for best effort class
    /// <see cref="BestEffort" />
    /// </summary>
    public class BestEffortActivity
    {
        /// <summary>
        /// Gets or sets activity id
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}