using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabaseWinForms.Services {
    public interface IDataContext {
        object DataContext { get; set; }
    }
}
