using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDatabaseWinForms.Services {
    public interface IView : IDataContext {
        DialogResult ShowDialog();
        void Close();
        DialogResult DialogResult { get; set; }
    }
}
