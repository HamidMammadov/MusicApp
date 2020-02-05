using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Artist:BaseEntity
    {
        public string Name { get; set; }
        public string Poster { get; set; }

        public ICollection<Albom> Alboms { get; set; }
    }
}
