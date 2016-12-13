namespace Accueil
{
    partial class frm_Film
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Film));
            this.lbx_Film = new System.Windows.Forms.ListBox();
            this.cbx_GenreFilm = new System.Windows.Forms.ComboBox();
            this.btn_ChercherFilm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbx_Film
            // 
            this.lbx_Film.FormattingEnabled = true;
            this.lbx_Film.Location = new System.Drawing.Point(211, 12);
            this.lbx_Film.Name = "lbx_Film";
            this.lbx_Film.Size = new System.Drawing.Size(211, 381);
            this.lbx_Film.TabIndex = 0;
            // 
            // cbx_GenreFilm
            // 
            this.cbx_GenreFilm.FormattingEnabled = true;
            this.cbx_GenreFilm.Items.AddRange(new object[] {
            "Rock",
            "Pop",
            "Electro",
            "Heavy Metal",
            "Opening"});
            this.cbx_GenreFilm.Location = new System.Drawing.Point(12, 12);
            this.cbx_GenreFilm.Name = "cbx_GenreFilm";
            this.cbx_GenreFilm.Size = new System.Drawing.Size(151, 21);
            this.cbx_GenreFilm.TabIndex = 1;
            // 
            // btn_ChercherFilm
            // 
            this.btn_ChercherFilm.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_ChercherFilm.Location = new System.Drawing.Point(12, 39);
            this.btn_ChercherFilm.Name = "btn_ChercherFilm";
            this.btn_ChercherFilm.Size = new System.Drawing.Size(88, 43);
            this.btn_ChercherFilm.TabIndex = 3;
            this.btn_ChercherFilm.Text = "Recherche";
            this.btn_ChercherFilm.UseVisualStyleBackColor = true;
            // 
            // frm_Film
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 412);
            this.Controls.Add(this.btn_ChercherFilm);
            this.Controls.Add(this.cbx_GenreFilm);
            this.Controls.Add(this.lbx_Film);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(450, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 450);
            this.Name = "frm_Film";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Film";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_Film;
        private System.Windows.Forms.ComboBox cbx_GenreFilm;
        private System.Windows.Forms.Button btn_ChercherFilm;
    }
}