using Newtonsoft.Json;

namespace HevyClient.Models
{
    public class ExerciseTemplate
    {
        [JsonProperty("id")]
        public required string Id { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("primary_muscle_group")]
        public string? PrimaryMuscleGroup { get; set; }

        [JsonProperty("secondary_muscle_groups")]
        public string[]? SecondaryMuscleGroups { get; set; }

        [JsonProperty("equipment")]
        public string? Equipment { get; set; }

        [JsonProperty("is_custom")]
        public bool IsCustom { get; set; }
    }
}
