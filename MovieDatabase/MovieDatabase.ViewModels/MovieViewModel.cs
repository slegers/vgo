using MovieDatabase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase.ViewModels
{
    class MovieViewModel : INotifyPropertyChanged
    {
        public MovieViewModel(Movie movie)
        {
            this.ID = movie.ID;
            this.Plot = movie.Plot;
            this.Year = movie.Year;
            this.PosterUrl = movie.PosterUrl;
            this.Title = movie.Title;
            this.Genre = movie.Genre.Split(',');
            this.Actors = movie.Actors.Split(',');
        }
        public bool Seen
        {
            get
            {
                var MovieRepo = new MovieRepository();
                return MovieRepo.FindById(this.ID).Seen;
            }
            set
            {
                var MovieRepo = new MovieRepository();
                MovieRepo.SeeById(this.ID,true);
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Seen"));
                }
            }
        }
        public bool Like
        {
           
            get
            {
                var MovieRepo = new MovieRepository();
                return MovieRepo.FindById(this.ID).Like;
            }

            set
            {
                var MovieRepo = new MovieRepository();
                MovieRepo.LikeById(this.ID, true);
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Like"));
                }
            }
        }
        public string ID { get; set; }

        public IEnumerable<string> Actors { get; set; }

        public string Plot { get; set; }

        public string PosterUrl { get; set; }

        public string Title { get; set; }

        public int? Year { get; set; }

        public string Director { get; set; }

        public IEnumerable<string> Genre { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
