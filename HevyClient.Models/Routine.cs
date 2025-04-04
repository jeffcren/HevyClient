using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HevyClient.Models
{
    public class Routine
    {
        [JsonProperty("id")]
        public required string Id { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("folder_id")]
        public int? FolderId { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("exercises")]
        public List<Exercise>? Exercises { get; set; }
    }
}
