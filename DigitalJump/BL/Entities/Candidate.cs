using System;
using System.Collections.Generic;

namespace DigitalJump.BL.Entities
{
    public class Candidate
    {
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public List<Education> Educations
        {
            get; set;
        }

        public List<Work> Works
        {
            get; set;
        }
    }
}
