using System.ComponentModel;
using System.Windows.Input;

namespace MovieDatabase.ViewModels
{
    class AddViewModel : INotifyPropertyChanged
    {
        public AddViewModel()       
        {

        }

        public ICommand Add { get; set;  }

        public ICommand Cancel { get; set; }

        public string ImdbId {
            set
            {
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("ImbdId"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}