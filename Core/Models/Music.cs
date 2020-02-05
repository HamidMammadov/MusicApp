using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Music:BaseEntity
    {
        public int AlbomId { get; set; }
        public string Name { get; set; }
        public string File { get; set; }
        public string Poster { get; set; }
        public int ListenCount { get; set; }
        public bool CanDownload { get; set; }
        public TimeSpan Duration { get; set; }

        public Albom Albom { get; set; }
    }
}
