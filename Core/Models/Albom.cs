using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Albom:BaseEntity
    {
        public int ArtistId { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Poster { get; set; }
        public string Desc { get; set; }
        public string Name { get; set; }

        public Artist Artist { get; set; }
        public ICollection<Music> Musics { get; set; }
    }
}
