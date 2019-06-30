using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DigitalJump.BL.Entities
{
    public class Candidate
    {
        [JsonProperty("Наименование")]
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public List<Education> Educations { get; set; }

        public List<Work> Works { get; set; }

        [JsonProperty("SkillsPassport")]
        public double SkillsPassport { get; set; }

        [JsonProperty("Сертификаты")]
        public double Serts { get; set; }

        [JsonProperty("Практика")]
        public double Practics { get; set; }

        [JsonProperty("ОбщийРейтинг")]
        public double TotalRait { get; set; }

        [JsonProperty("УчебноеЗаведение")]
        public string Vuz {get;set;}
    }
}
