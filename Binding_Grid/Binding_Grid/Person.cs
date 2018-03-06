using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binding_Grid
{
    public class Person : INotifyPropertyChanged  
    {
        private string _first, _last;
        public event PropertyChangedEventHandler PropertyChanged;
        public Person(String first = "Tom", String last = "Ato")
        {
            this.Firstname = first;
            this.Lastname = last;
        }
            public String Firstname
        {
            get
            {
                return _first;
            }
            set
            { 
                _first = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Firstname"));
                }
            }
        }

        public String Lastname
        {
            get
            {
                return this._last;
            }
            set
            {
                this._last = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Lastname"));
                }
            }
        }
        
    }
}
