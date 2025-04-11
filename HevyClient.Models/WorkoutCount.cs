using Newtonsoft.Json;

namespace HevyClient.Models
{
    public class WorkoutCount
    {
        [JsonProperty("workout_count")]
        public int Count { get; set; }
    }
}
