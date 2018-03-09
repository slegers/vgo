using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase.Models {
    public class Movie {
        [Key]
        public string ID { get; set; }
        public string Actors { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public string Plot { get; set; }
        public string PosterUrl { get; set; }
        public string Title { get; set; }
        public int? Year { get; set; }
        public bool Seen { get; set; }
        public bool Like { get; set; }
    }
}
