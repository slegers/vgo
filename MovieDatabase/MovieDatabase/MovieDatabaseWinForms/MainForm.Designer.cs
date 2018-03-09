namespace MovieDatabaseWinForms {
    partial class MainForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.MoviesList = new System.Windows.Forms.ListBox();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.MoviesList);
            this.SplitContainer.Panel1.Controls.Add(this.BottomPanel);
            this.SplitContainer.Panel1MinSize = 200;
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Resize += new System.EventHandler(this.SplitContainer_Panel2_Resize);
            this.SplitContainer.Panel2MinSize = 350;
            this.SplitContainer.Size = new System.Drawing.Size(681, 401);
            this.SplitContainer.SplitterDistance = 227;
            this.SplitContainer.TabIndex = 0;
            // 
            // MoviesList
            // 
            this.MoviesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoviesList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.MoviesList.FormattingEnabled = true;
            this.MoviesList.IntegralHeight = false;
            this.MoviesList.ItemHeight = 48;
            this.MoviesList.Location = new System.Drawing.Point(0, 0);
            this.MoviesList.Name = "MoviesList";
            this.MoviesList.Size = new System.Drawing.Size(227, 344);
            this.MoviesList.TabIndex = 2;
            this.MoviesList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.MoviesList_DrawItem);
            this.MoviesList.SelectedIndexChanged += new System.EventHandler(this.MoviesList_SelectedIndexChanged);
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.AddButton);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 344);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(227, 57);
            this.BottomPanel.TabIndex = 1;
            this.BottomPanel.Resize += new System.EventHandler(this.BottomPanel_Resize);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(64, 8);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(97, 44);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 401);
            this.Controls.Add(this.SplitContainer);
            this.MinimumSize = new System.Drawing.Size(570, 400);
            this.Name = "MainForm";
            this.Text = "Movie Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.SplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.ListBox MoviesList;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Button AddButton;
    }
}