using Microsoft.Practices.ServiceLocation;
using MovieDatabase.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDatabaseWinForms.Services {
    public class WindowService : IWindowService {
        public WindowService() {
            _currentDialogs = new LinkedList<IView>();
        }
        /// <summary>
        /// Closes the active dialog window.
        /// </summary>
        /// <param name="result">The value the DialogResult property of the window should be set to.</param>
        public void CloseDialog(bool result) {
            if (_currentDialogs.Count == 0)
                throw new NotSupportedException("No dialog open at this time.");
            _currentDialogs.Last.Value.DialogResult = result ? DialogResult.OK : DialogResult.Cancel;
        }

        public void CloseWindow(object window) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Shows a modal window associated with a given viewmodel object. The association between the view and viewmodel
        /// is defined in the service locator.
        /// </summary>
        /// <param name="viewModel">The viewmodel object to use when looking up the corresponding view.</param>
        /// <returns>The value of the DialogResult property.</returns>
        public bool ShowDialog(object viewModel) {
            if (viewModel == null)
                throw new ArgumentNullException(nameof(viewModel));
            var window = ServiceLocator.Current.GetInstance<IView>(viewModel.GetType().FullName);
            window.DataContext = viewModel;
            _currentDialogs.AddLast(window);
            var ret = window.ShowDialog();
            _currentDialogs.RemoveLast();
            return ret == DialogResult.OK;
        }

        public object ShowWindow(object viewModel) {
            throw new NotImplementedException();
        }
        private LinkedList<IView> _currentDialogs;
    }
}
