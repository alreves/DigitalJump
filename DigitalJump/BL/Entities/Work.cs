using System;

namespace DigitalJump.BL.Entities
{
    public class Work
    {
        public Organization WorkOrganization
        {
            get; set;
        }

        public DateTime BeginDate { get; set; }

        public DateTime EndDate { get; set; }

        public Post Post { get; set; }

        public bool IsPractic { get; set; }
    }

}
