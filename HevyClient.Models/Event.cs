using Newtonsoft.Json;

namespace HevyClient.Models
{
    public class Event
    {
        [JsonProperty("type")]
        public required string Type { get; set; }

        [JsonProperty("workout")]
        public required Workout Workout { get; set; }
    }
}
