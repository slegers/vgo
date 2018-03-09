using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieDatabaseWinForms.Services;
using MovieDatabase.ViewModels;

namespace MovieDatabaseWinForms {
    public partial class MovieInfoControl : UserControl, IDataContext {
        public MovieInfoControl() {
            InitializeComponent();
            _captions = new Label[] { LIdLabel, LDirectorLabel, LGenreLabel, LPlotLabel, LActorsLabel };
            _contents = new Label[] { IdLabel, DirectorLabel, GenreLabel, PlotLabel, ActorsLabel };
        }

        public object DataContext {
            get {
                return _model;
            }
            set {
                Unhook();
                _model = value as MovieViewModel;
                Hook();
            }
        }
        private MovieViewModel _model;
        private Label[] _captions, _contents;
        private void Hook() {
            if (_model != null) {
                TitleLabel.Text = _model.Title;
                IdLabel.Text = _model.ID;
                DirectorLabel.Text = _model.Director;
                GenreLabel.Text = string.Join(", ", _model.Genre);
                PlotLabel.Text = _model.Plot;
                ActorsLabel.Text = string.Join(", ", _model.Actors);
                SeenCheck.Checked = _model.Seen;
                LikeCheck.Checked = _model.Like;
                Reposition();
                _model.PropertyChanged += _model_PropertyChanged;
            }
        }
        private void _model_PropertyChanged(object sender, PropertyChangedEventArgs e) {
            if (e.PropertyName == nameof(MovieViewModel.Seen) && SeenCheck.Checked != _model.Seen) {
                SeenCheck.Checked = _model.Seen;
            }
            if (e.PropertyName == nameof(MovieViewModel.Like) && LikeCheck.Checked != _model.Like) {
                LikeCheck.Checked = _model.Like;
            }
        }

        private void Unhook() {
            if (_model != null) {

            }
        }
        private void Reposition() {
            const int hspace = 5;
            const int vspace = 10;
            PosterImage.Left = this.Width - PosterImage.Width;
            using (var g = this.CreateGraphics()) {
                float maxW = 0f;
                foreach (var l in _captions) {
                    var size = g.MeasureString(l.Text, l.Font);
                    l.Width = (int)size.Width;
                    l.Height = (int)size.Height;
                    if (size.Width > maxW)
                        maxW = size.Width;
                }
                int maxContW = this.Width - PosterImage.Width - (int)maxW - 3 * hspace;
                int currentTop = TitleLabel.Top + TitleLabel.Height + vspace;
                for (int i = 0; i < _contents.Length; i++) {
                    _captions[i].Left = hspace;
                    _captions[i].Top = currentTop;
                    _contents[i].Left = (int)maxW + 2 * hspace;
                    _contents[i].Top = currentTop;
                    var size = g.MeasureString(_contents[i].Text, _contents[i].Font, maxContW);
                    _contents[i].Width = (int)size.Width;
                    _contents[i].Height = (int)size.Height;
                    currentTop += Math.Max(_captions[i].Height, _contents[i].Height) + vspace;
                }
                SeenCheck.Top = currentTop;
                SeenCheck.Left = (int)maxW + 2 * hspace;
                LikeCheck.Top = currentTop + SeenCheck.Height + vspace;
                LikeCheck.Left = (int)maxW + 2 * hspace;
            }
        }

        private void PosterImage_Paint(object sender, PaintEventArgs e) {
            const int hspace = 5;
            const int vspace = 10;
            var image = ImageCache.GetImage(_model.PosterUrl);
            e.Graphics.DrawImage(image, new Rectangle() { X = hspace, Y = vspace, Width = PosterImage.Width - 2 * hspace, Height =(int) (image.Height * (PosterImage.Width / (float)image.Width) - 2 * vspace) });
        }

        private void MovieInfoControl_Load(object sender, EventArgs e) {
            
        }

        private void SeenCheck_CheckedChanged(object sender, EventArgs e) {
            _model.Seen = SeenCheck.Checked;
        }

        private void LikeCheck_CheckedChanged(object sender, EventArgs e) {
            _model.Like = LikeCheck.Checked;
        }

        private void MovieInfoControl_Resize(object sender, EventArgs e) {
            Reposition();
        }
    }
}
