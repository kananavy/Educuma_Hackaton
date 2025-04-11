using System;
using Newtonsoft.Json;

namespace Educma_Hackaton.models
{
    internal class InfoCreationSchedule
    {
        [JsonProperty("subject")]
        public string? matiere { get; set; }

        [JsonProperty("day")]
        public string? jour { get; set; }

        [JsonProperty("start")]
        public string? heureStart { get; set; }

        [JsonProperty("end")]
        public string? heureEnd { get; set; }

        [JsonProperty("teacherId")]
        public string? idTeacher { get; set; }

        [JsonProperty("school")]
        public string? univName { get; set; }

        [JsonProperty("department")]
        public string? parcours { get; set; }

        [JsonProperty("level")]
        public string? niveau { get; set; }
    }
}
