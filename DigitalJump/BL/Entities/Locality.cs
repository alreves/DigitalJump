using System.Collections.Generic;

namespace DigitalJump.BL.Entities
{
    public class Locality
    {
        public string Name { get; set; }

        public Locality Parent { get; set; }

        public List<Locality> Children { get; set; }
    }
}
