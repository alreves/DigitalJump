namespace DigitalJump.BL
{
    public class Summary
    {
        public Post Post { get; set; }

        public bool IsPractic { get; set; }

        public Locality Locality { get; set; }

        public Candidate Candidate { get; set; }
               
        public Specialization Specialization { get; set; }

        public int Wage { get; set; }

        public string Description { get; set; }

        public string ContactData { get; set; }

        public bool IsActive { get; set; }
    }
}
