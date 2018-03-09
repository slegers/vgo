namespace MovieDatabaseWinForms {
    partial class MovieInfoControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.PosterImage = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.LIdLabel = new System.Windows.Forms.Label();
            this.LDirectorLabel = new System.Windows.Forms.Label();
            this.LGenreLabel = new System.Windows.Forms.Label();
            this.LPlotLabel = new System.Windows.Forms.Label();
            this.LActorsLabel = new System.Windows.Forms.Label();
            this.DirectorLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.PlotLabel = new System.Windows.Forms.Label();
            this.ActorsLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SeenCheck = new System.Windows.Forms.CheckBox();
            this.LikeCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PosterImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PosterImage
            // 
            this.PosterImage.Location = new System.Drawing.Point(509, 42);
            this.PosterImage.Name = "PosterImage";
            this.PosterImage.Size = new System.Drawing.Size(170, 408);
            this.PosterImage.TabIndex = 0;
            this.PosterImage.TabStop = false;
            this.PosterImage.Paint += new System.Windows.Forms.PaintEventHandler(this.PosterImage_Paint);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(679, 39);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "#";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LIdLabel
            // 
            this.LIdLabel.AutoSize = true;
            this.LIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIdLabel.Location = new System.Drawing.Point(5, 49);
            this.LIdLabel.Name = "LIdLabel";
            this.LIdLabel.Size = new System.Drawing.Size(57, 13);
            this.LIdLabel.TabIndex = 5;
            this.LIdLabel.Text = "IMDB Id:";
            // 
            // LDirectorLabel
            // 
            this.LDirectorLabel.AutoSize = true;
            this.LDirectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDirectorLabel.Location = new System.Drawing.Point(6, 66);
            this.LDirectorLabel.Name = "LDirectorLabel";
            this.LDirectorLabel.Size = new System.Drawing.Size(56, 13);
            this.LDirectorLabel.TabIndex = 6;
            this.LDirectorLabel.Text = "Director:";
            // 
            // LGenreLabel
            // 
            this.LGenreLabel.AutoSize = true;
            this.LGenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGenreLabel.Location = new System.Drawing.Point(6, 82);
            this.LGenreLabel.Name = "LGenreLabel";
            this.LGenreLabel.Size = new System.Drawing.Size(45, 13);
            this.LGenreLabel.TabIndex = 7;
            this.LGenreLabel.Text = "Genre:";
            // 
            // LPlotLabel
            // 
            this.LPlotLabel.AutoSize = true;
            this.LPlotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPlotLabel.Location = new System.Drawing.Point(6, 100);
            this.LPlotLabel.Name = "LPlotLabel";
            this.LPlotLabel.Size = new System.Drawing.Size(33, 13);
            this.LPlotLabel.TabIndex = 8;
            this.LPlotLabel.Text = "Plot:";
            // 
            // LActorsLabel
            // 
            this.LActorsLabel.AutoSize = true;
            this.LActorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LActorsLabel.Location = new System.Drawing.Point(6, 118);
            this.LActorsLabel.Name = "LActorsLabel";
            this.LActorsLabel.Size = new System.Drawing.Size(47, 13);
            this.LActorsLabel.TabIndex = 9;
            this.LActorsLabel.Text = "Actors:";
            // 
            // DirectorLabel
            // 
            this.DirectorLabel.Location = new System.Drawing.Point(68, 66);
            this.DirectorLabel.Name = "DirectorLabel";
            this.DirectorLabel.Size = new System.Drawing.Size(35, 13);
            this.DirectorLabel.TabIndex = 12;
            this.DirectorLabel.Text = "#";
            // 
            // GenreLabel
            // 
            this.GenreLabel.Location = new System.Drawing.Point(68, 82);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(91, 13);
            this.GenreLabel.TabIndex = 13;
            this.GenreLabel.Text = "#";
            // 
            // PlotLabel
            // 
            this.PlotLabel.Location = new System.Drawing.Point(68, 100);
            this.PlotLabel.Name = "PlotLabel";
            this.PlotLabel.Size = new System.Drawing.Size(35, 13);
            this.PlotLabel.TabIndex = 14;
            this.PlotLabel.Text = "#";
            // 
            // ActorsLabel
            // 
            this.ActorsLabel.Location = new System.Drawing.Point(69, 118);
            this.ActorsLabel.Name = "ActorsLabel";
            this.ActorsLabel.Size = new System.Drawing.Size(35, 13);
            this.ActorsLabel.TabIndex = 15;
            this.ActorsLabel.Text = "#";
            // 
            // IdLabel
            // 
            this.IdLabel.Location = new System.Drawing.Point(68, 49);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(41, 13);
            this.IdLabel.TabIndex = 16;
            this.IdLabel.Text = "#";
            // 
            // SeenCheck
            // 
            this.SeenCheck.AutoSize = true;
            this.SeenCheck.Location = new System.Drawing.Point(72, 149);
            this.SeenCheck.Name = "SeenCheck";
            this.SeenCheck.Size = new System.Drawing.Size(51, 17);
            this.SeenCheck.TabIndex = 17;
            this.SeenCheck.Text = "Seen";
            this.SeenCheck.UseVisualStyleBackColor = true;
            this.SeenCheck.CheckedChanged += new System.EventHandler(this.SeenCheck_CheckedChanged);
            // 
            // LikeCheck
            // 
            this.LikeCheck.AutoSize = true;
            this.LikeCheck.Location = new System.Drawing.Point(71, 172);
            this.LikeCheck.Name = "LikeCheck";
            this.LikeCheck.Size = new System.Drawing.Size(52, 17);
            this.LikeCheck.TabIndex = 18;
            this.LikeCheck.Text = "Liked";
            this.LikeCheck.UseVisualStyleBackColor = true;
            this.LikeCheck.CheckedChanged += new System.EventHandler(this.LikeCheck_CheckedChanged);
            // 
            // MovieInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.LikeCheck);
            this.Controls.Add(this.SeenCheck);
            this.Controls.Add(this.DirectorLabel);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.PlotLabel);
            this.Controls.Add(this.ActorsLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.LIdLabel);
            this.Controls.Add(this.LDirectorLabel);
            this.Controls.Add(this.LGenreLabel);
            this.Controls.Add(this.LPlotLabel);
            this.Controls.Add(this.LActorsLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.PosterImage);
            this.Name = "MovieInfoControl";
            this.Size = new System.Drawing.Size(679, 450);
            this.Load += new System.EventHandler(this.MovieInfoControl_Load);
            this.Resize += new System.EventHandler(this.MovieInfoControl_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.PosterImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PosterImage;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label LIdLabel;
        private System.Windows.Forms.Label LDirectorLabel;
        private System.Windows.Forms.Label LGenreLabel;
        private System.Windows.Forms.Label LPlotLabel;
        private System.Windows.Forms.Label LActorsLabel;
        private System.Windows.Forms.Label DirectorLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label PlotLabel;
        private System.Windows.Forms.Label ActorsLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.CheckBox SeenCheck;
        private System.Windows.Forms.CheckBox LikeCheck;
    }
}
