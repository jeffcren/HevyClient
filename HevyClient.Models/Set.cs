using Newtonsoft.Json;

namespace HevyClient.Models
{
    public class Set
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("weight_kg")]
        public double? WeightKg { get; set; }

        [JsonProperty("reps")]
        public int? Reps { get; set; }

        [JsonProperty("distance_meters")]
        public int? DistanceMeters { get; set; }

        [JsonProperty("duration_seconds")]
        public int? DurationSeconds { get; set; }

        [JsonProperty("rpe")]
        public double? RPE { get; set; }

        [JsonProperty("custom_metric")]
        public int? CustomMetric { get; set; }
    }
}
