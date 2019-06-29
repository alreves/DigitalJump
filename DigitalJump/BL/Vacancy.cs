namespace DigitalJump.BL
{
    public class Vacancy
    {
        public Locality Locality { get; set; }

        public Post Post { get; set; }

        public bool IsPractic { get; set; }

        public Organization Organization { get; set; }

        public int MinWage { get; set; }

        public int MaxWage { get; set; }

        public string Description { get; set; }

        public string ContactData { get; set; }

        public Specialization Specialization { get; set; }

        public bool IsActive { get; set; }
    }
}
