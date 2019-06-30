using DigitalJump.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalJump.Models
{
    public class CandidatsViewModel
    {
        public List<Candidate> Candidats { get; set; }

        public MainStat MainStat { get; set; }
    }
}
