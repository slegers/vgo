using MovieDatabase.ViewModels;
using MovieDatabaseWinForms.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDatabaseWinForms {
    public partial class AddForm : Form, IView {
        public AddForm() {
            InitializeComponent();
            _model = null;
        }

        public object DataContext {
            get {
                return _model;
            }
            set {
                Unhook();
                _model = value as AddViewModel;
                Hook();
            }
        }
        private AddViewModel _model;

        private void Unhook() {
            if (_model != null) {
                _model.Add.CanExecuteChanged -= Add_CanExecuteChanged;
                _model.Cancel.CanExecuteChanged -= Cancel_CanExecuteChanged;
                _model.PropertyChanged -= _model_PropertyChanged;
            }
        }
        private void Hook() {
            if (_model != null) {
                _model.Add.CanExecuteChanged += Add_CanExecuteChanged;
                _model.Cancel.CanExecuteChanged += Cancel_CanExecuteChanged;
                _model.PropertyChanged += _model_PropertyChanged;
                AddButton.Enabled = _model.Add.CanExecute(null);
                CancelButton.Enabled = _model.Cancel.CanExecute(null);
            }
        }
        private void _model_PropertyChanged(object sender, PropertyChangedEventArgs e) {
            if (e.PropertyName == nameof(AddViewModel.ImdbId) && _model.ImdbId != ImdbIdText.Text) {
                ImdbIdText.Text = _model.ImdbId;
            }
        }
        private void Cancel_CanExecuteChanged(object sender, EventArgs e) {
            CancelButton.Enabled = _model.Cancel.CanExecute(null);
        }
        private void Add_CanExecuteChanged(object sender, EventArgs e) {
            AddButton.Enabled = _model.Add.CanExecute(null);
        }

        private void AddButton_Click(object sender, EventArgs e) {
            if (_model != null) {
                _model.Add.Execute(null);
            }
        }
        private void CancelButton_Click(object sender, EventArgs e) {
            if (_model != null) {
                _model.Cancel.Execute(null);
            }
        }
        private void ImdbIdText_TextChanged(object sender, EventArgs e) {
            if (_model != null)
                _model.ImdbId = ImdbIdText.Text;
        }
        protected override void OnClosed(EventArgs e) {
            DataContext = null; // unhook
            base.OnClosed(e);
        }
    }
}
