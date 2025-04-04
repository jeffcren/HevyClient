using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HevyClient.Models
{
    public class WorkoutCount
    {
        [JsonProperty("workout_count")]
        public int Count { get; set; }
    }
}
