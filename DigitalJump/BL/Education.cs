namespace DigitalJump.BL
{
    public class Education
    {
        public Organization EducationOrganization
        {
            get;set;
        }

        public int BeginYear { get; set; }

        public int EndYear { get; set; }

        public string Faculty { get; set; }

        public string Specialty { get; set; }
    }
}
