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
    public partial class MainForm : Form, IView {
        public MainForm() {
            InitializeComponent();
        }

        private void Add_CanExecuteChanged(object sender, EventArgs e) {
            AddButton.Enabled = _model.Add.CanExecute(null);
        }

        private void DataContext_PropertyChanged(object sender, PropertyChangedEventArgs e) {
            if (e.PropertyName == nameof(MainViewModel.Movies)) {
                MoviesList.Items.Clear();
                MoviesList.Items.AddRange(_model.Movies.ToArray());
            }
            if (e.PropertyName == nameof(MainViewModel.SelectedMovie)) {
                if (MoviesList.SelectedItem != _model.SelectedMovie)
                    MoviesList.SelectedItem = _model.SelectedMovie;
                var cont = SplitContainer.Panel2.Controls;
                if (_activeSubView != null) {
                    cont.Remove(_activeSubView);
                }
                _activeSubView = new MovieInfoControl();
                _activeSubView.DataContext = _model.SelectedMovie;
                _activeSubView.Width = SplitContainer.Panel2.Width;
                _activeSubView.Height = SplitContainer.Panel2.Height;
                cont.Add(_activeSubView);
            }
        }

        public object DataContext {
            get {
                return _model;
            }
            set {
                Unhook();
                _model = value as MainViewModel;
                Hook();
            }
        }
        private MainViewModel _model;
        private MovieInfoControl _activeSubView;

        private void Unhook() {
            if (_model != null) {
                _model.PropertyChanged -= DataContext_PropertyChanged;
                _model.Add.CanExecuteChanged -= Add_CanExecuteChanged;
            }
        }
        private void Hook() {
            if (_model != null) {
                MoviesList.Items.AddRange(_model.Movies.ToArray());
                _model.PropertyChanged += DataContext_PropertyChanged;
                _model.Add.CanExecuteChanged += Add_CanExecuteChanged;
                AddButton.Enabled = _model.Add.CanExecute(null);
            }
        }
        private void MoviesList_DrawItem(object sender, DrawItemEventArgs e) {
            var lb = sender as ListBox;
            var movie = lb.Items[e.Index] as MovieViewModel;
            e.DrawBackground();
            e.DrawFocusRectangle();
            var image = ImageCache.GetImage(movie.PosterUrl);
            e.Graphics.DrawImage(image, new Rectangle() { X = e.Bounds.Left + 3, Y = e.Bounds.Top + 3, Width = 42, Height = 42 }, new Rectangle() { X = 0, Y = 0, Width = image.Width, Height = image.Height }, GraphicsUnit.Pixel);
            e.Graphics.DrawString(movie.Title, new Font(e.Font, FontStyle.Bold), Brushes.Black, e.Bounds.Left + 50, e.Bounds.Top + 8);
            e.Graphics.DrawString(movie.Director + ", " + movie.Year, e.Font, Brushes.Black, e.Bounds.Left + 50, e.Bounds.Top + 24);
        }

        private void AddButton_Click(object sender, EventArgs e) {
            _model.Add.Execute(null);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            this.DataContext = null; // unhook
        }

        private void BottomPanel_Resize(object sender, EventArgs e) {
            AddButton.Left = (BottomPanel.Width - AddButton.Width) / 2;
        }

        private void MoviesList_SelectedIndexChanged(object sender, EventArgs e) {
            _model.SelectedMovie = MoviesList.SelectedItem as MovieViewModel;
        }

        private void SplitContainer_Panel2_Resize(object sender, EventArgs e) {
            if (_activeSubView != null) {
                _activeSubView.Width = SplitContainer.Panel2.Width;
                _activeSubView.Height = SplitContainer.Panel2.Height;
            }
        }
    }
}
