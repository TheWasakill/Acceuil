namespace Accueil
{
    partial class frm_Musique
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Musique));
            this.cbx_GenreMusique = new System.Windows.Forms.ComboBox();
            this.lbx_Musique = new System.Windows.Forms.ListBox();
            this.lbl_GemreMusique = new System.Windows.Forms.Label();
            this.lbl_Manga = new System.Windows.Forms.Label();
            this.cbx_Manga = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbx_GenreMusique
            // 
            this.cbx_GenreMusique.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_GenreMusique.FormattingEnabled = true;
            this.cbx_GenreMusique.IntegralHeight = false;
            this.cbx_GenreMusique.Items.AddRange(new object[] {
            "Rock",
            "Pop",
            "Electro",
            "Heavy Metal",
            "Opening"});
            this.cbx_GenreMusique.Location = new System.Drawing.Point(12, 28);
            this.cbx_GenreMusique.Name = "cbx_GenreMusique";
            this.cbx_GenreMusique.Size = new System.Drawing.Size(151, 21);
            this.cbx_GenreMusique.TabIndex = 0;
            // 
            // lbx_Musique
            // 
            this.lbx_Musique.FormattingEnabled = true;
            this.lbx_Musique.Location = new System.Drawing.Point(211, 12);
            this.lbx_Musique.MaximumSize = new System.Drawing.Size(211, 381);
            this.lbx_Musique.MinimumSize = new System.Drawing.Size(211, 381);
            this.lbx_Musique.Name = "lbx_Musique";
            this.lbx_Musique.Size = new System.Drawing.Size(211, 381);
            this.lbx_Musique.TabIndex = 1;
            // 
            // lbl_GemreMusique
            // 
            this.lbl_GemreMusique.AutoSize = true;
            this.lbl_GemreMusique.Location = new System.Drawing.Point(12, 12);
            this.lbl_GemreMusique.Name = "lbl_GemreMusique";
            this.lbl_GemreMusique.Size = new System.Drawing.Size(79, 13);
            this.lbl_GemreMusique.TabIndex = 2;
            this.lbl_GemreMusique.Text = "Genre Musique";
            // 
            // lbl_Manga
            // 
            this.lbl_Manga.AutoSize = true;
            this.lbl_Manga.Location = new System.Drawing.Point(12, 76);
            this.lbl_Manga.Name = "lbl_Manga";
            this.lbl_Manga.Size = new System.Drawing.Size(40, 13);
            this.lbl_Manga.TabIndex = 3;
            this.lbl_Manga.Text = "Manga";
            // 
            // cbx_Manga
            // 
            this.cbx_Manga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Manga.FormattingEnabled = true;
            this.cbx_Manga.IntegralHeight = false;
            this.cbx_Manga.Items.AddRange(new object[] {
            "Fairy Tail",
            "Sword Art Online",
            "Tokyo Ghoul"});
            this.cbx_Manga.Location = new System.Drawing.Point(12, 92);
            this.cbx_Manga.Name = "cbx_Manga";
            this.cbx_Manga.Size = new System.Drawing.Size(151, 21);
            this.cbx_Manga.TabIndex = 4;
            // 
            // frm_Musique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 412);
            this.Controls.Add(this.cbx_Manga);
            this.Controls.Add(this.lbl_Manga);
            this.Controls.Add(this.lbl_GemreMusique);
            this.Controls.Add(this.lbx_Musique);
            this.Controls.Add(this.cbx_GenreMusique);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(450, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 450);
            this.Name = "frm_Musique";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musiques";
            this.Load += new System.EventHandler(this.frm_Musique_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_GenreMusique;
        private System.Windows.Forms.ListBox lbx_Musique;
        private System.Windows.Forms.Label lbl_GemreMusique;
        private System.Windows.Forms.Label lbl_Manga;
        private System.Windows.Forms.ComboBox cbx_Manga;
    }
}