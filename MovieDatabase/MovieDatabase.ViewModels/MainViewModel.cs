using MovieDatabase.Interfaces;
using MovieDatabase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MovieDatabase.ViewModels 
{
    class MainViewModel : INotifyPropertyChanged

    {
        public MainViewModel()
        {
            this.Add = new AddCommand();
            MovieRepository repo = new MovieRepository();
            this.Movies = 
            this.SelectedMovie = repo.FindById("tt0107290");
        }

        public ICommand Add{
            set
            {
                AddCommand add = new AddCommand();
                add.Execute(null);
            }
        }

        public MovieViewModel SelectedMovie {
            set
            {
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("SelectedMovie"));
                }
            }
                
        }

        public IEnumerable<MovieViewModel> Movies { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        
    }
    class AddCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) { return true; }


        public void Execute(object parameter)
        {
            IWindowService service = new Window();
            service.ShowDialog(new AddViewModel());
        }
    }
}
