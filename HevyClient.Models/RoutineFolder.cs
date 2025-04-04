using Newtonsoft.Json;

namespace HevyClient.Models
{
    public class RoutineFolder
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}
