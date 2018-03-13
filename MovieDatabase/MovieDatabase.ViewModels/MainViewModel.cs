using Microsoft.Practices.ServiceLocation;
using MovieDatabase.Interfaces;
using MovieDatabase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;

namespace MovieDatabase.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        private List<MovieViewModel> MovieList = new List<MovieViewModel>();
        public MainViewModel()
        {
            this.Add = new AddCommand();
            MovieRepository repo = new MovieRepository();
            
            foreach (Movie movie in repo.Entries)
            {

                MovieList.Add(new MovieViewModel(movie));
            }
            SelectedMovie = MovieList[0];
           
        }

        public ICommand Add{
            get;set;
        }

        public MovieViewModel SelectedMovie {
            set
            {
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(SelectedMovie)));
                }
            }
                
        }

        public IEnumerable<MovieViewModel> Movies {
            get
            {
                return MovieList;
            }
            
        }
  

        public event PropertyChangedEventHandler PropertyChanged;

        
    }
    class AddCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) { return true; }


        public void Execute(object parameter)
        {
            IWindowService service = ServiceLocator.Current.GetInstance<IWindowService>();
            var window = service.ShowWindow(new AddViewModel());
        }
    }
}
