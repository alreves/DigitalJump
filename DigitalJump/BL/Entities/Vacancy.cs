using Newtonsoft.Json;

namespace DigitalJump.BL.Entities
{
    public class Vacancy
    {
        [JsonProperty("GUID")]
        public string Uid
        {
            get; set;
        }

        [JsonProperty("НаселенныйПункт")]
        public string Locality { get; set; }

        [JsonProperty("Должность")]
        public string Post { get; set; }

        [JsonProperty("Практика")]
        public bool IsPractic { get; set; }

        [JsonProperty("Организация")]
        public string Organization { get; set; }

        [JsonProperty("ОкладМинимум")]
        public int MinWage { get; set; }

        [JsonProperty("ОкладМаксимум")]
        public int MaxWage { get; set; }

        [JsonProperty("ДополнительноеОписание")]
        public string Description { get; set; }

        [JsonProperty("КонтактныеДанные")]
        public string ContactData { get; set; }

        [JsonProperty("Специализация")]
        public string Specialization { get; set; }

        [JsonProperty("Активная")]
        public bool IsActive { get; set; }
    }
}
