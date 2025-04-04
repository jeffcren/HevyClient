using Newtonsoft.Json;

namespace HevyClient.Models
{
    public class Exercise
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("notes")]
        public string? Notes { get; set; }

        [JsonProperty("exercise_template_id")]
        public string? ExerciseTemplateId { get; set; }

        [JsonProperty("superset_id")]
        public int? SupersetId { get; set; }

        [JsonProperty("sets")]
        public List<Set>? Sets { get; set; }
    }
}
