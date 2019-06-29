using DigitalJump.BL;
using DigitalJump.BL.Entities;
using System.Collections.Generic;

namespace DigitalJump.Models
{
    public class HomeViewModel
    {
        public MainStat MainStat { get; set; }

        public List<Vacancy> HotVacancies { get; set; }
    }
}
