using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binding_Grid
{
    public class Person  
    {
        private string _first, _last;
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
            }
        }
        
    }
}
