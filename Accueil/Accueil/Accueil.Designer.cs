namespace Accueil
{
    partial class Accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.btn_Musique = new System.Windows.Forms.Button();
            this.btn_Film = new System.Windows.Forms.Button();
            this.btn_Anime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Musique
            // 
            this.btn_Musique.BackColor = System.Drawing.Color.Black;
            this.btn_Musique.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Musique.BackgroundImage")));
            this.btn_Musique.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Musique.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Musique.Font = new System.Drawing.Font("Carnivalee Freakshow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Musique.ForeColor = System.Drawing.Color.White;
            this.btn_Musique.Location = new System.Drawing.Point(141, 12);
            this.btn_Musique.Name = "btn_Musique";
            this.btn_Musique.Size = new System.Drawing.Size(86, 34);
            this.btn_Musique.TabIndex = 0;
            this.btn_Musique.Text = "Musiques";
            this.btn_Musique.UseVisualStyleBackColor = false;
            this.btn_Musique.Click += new System.EventHandler(this.btn_Musique_Click);
            // 
            // btn_Film
            // 
            this.btn_Film.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Film.BackgroundImage")));
            this.btn_Film.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Film.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Film.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Film.ForeColor = System.Drawing.Color.Gray;
            this.btn_Film.Location = new System.Drawing.Point(141, 63);
            this.btn_Film.Name = "btn_Film";
            this.btn_Film.Size = new System.Drawing.Size(86, 34);
            this.btn_Film.TabIndex = 1;
            this.btn_Film.Text = "Films";
            this.btn_Film.UseVisualStyleBackColor = true;
            // 
            // btn_Anime
            // 
            this.btn_Anime.BackColor = System.Drawing.Color.Plum;
            this.btn_Anime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Anime.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Anime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Anime.Location = new System.Drawing.Point(141, 115);
            this.btn_Anime.Name = "btn_Anime";
            this.btn_Anime.Size = new System.Drawing.Size(86, 34);
            this.btn_Anime.TabIndex = 2;
            this.btn_Anime.Text = "Animes";
            this.btn_Anime.UseVisualStyleBackColor = false;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(380, 317);
            this.Controls.Add(this.btn_Anime);
            this.Controls.Add(this.btn_Film);
            this.Controls.Add(this.btn_Musique);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(396, 355);
            this.MinimumSize = new System.Drawing.Size(396, 355);
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Musique;
        private System.Windows.Forms.Button btn_Film;
        private System.Windows.Forms.Button btn_Anime;
    }
}

