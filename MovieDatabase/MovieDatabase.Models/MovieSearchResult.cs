using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase.Models {
    public class MovieSearchResult {
        public string ID { get; set; }
        public string Title { get; set; }
        public string PosterUrl { get; set; }
        public int Year { get; set; }
    }
}
