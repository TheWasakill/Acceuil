namespace Mediacenter
{
    partial class frm_accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Musique = new System.Windows.Forms.Button();
            this.btn_Film = new System.Windows.Forms.Button();
            this.btn_Anime = new System.Windows.Forms.Button();
            this.btn_Series = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Musique
            // 
            this.btn_Musique.Location = new System.Drawing.Point(12, 12);
            this.btn_Musique.Name = "btn_Musique";
            this.btn_Musique.Size = new System.Drawing.Size(82, 38);
            this.btn_Musique.TabIndex = 0;
            this.btn_Musique.Text = "Musiques";
            this.btn_Musique.UseVisualStyleBackColor = true;
            // 
            // btn_Film
            // 
            this.btn_Film.Location = new System.Drawing.Point(190, 12);
            this.btn_Film.Name = "btn_Film";
            this.btn_Film.Size = new System.Drawing.Size(82, 38);
            this.btn_Film.TabIndex = 1;
            this.btn_Film.Text = "Films";
            this.btn_Film.UseVisualStyleBackColor = true;
            // 
            // btn_Anime
            // 
            this.btn_Anime.Location = new System.Drawing.Point(12, 212);
            this.btn_Anime.Name = "btn_Anime";
            this.btn_Anime.Size = new System.Drawing.Size(82, 38);
            this.btn_Anime.TabIndex = 2;
            this.btn_Anime.Text = "Animes";
            this.btn_Anime.UseVisualStyleBackColor = true;
            // 
            // btn_Series
            // 
            this.btn_Series.Location = new System.Drawing.Point(190, 212);
            this.btn_Series.Name = "btn_Series";
            this.btn_Series.Size = new System.Drawing.Size(82, 38);
            this.btn_Series.TabIndex = 3;
            this.btn_Series.Text = "Séries";
            this.btn_Series.UseVisualStyleBackColor = true;
            // 
            // frm_accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_Series);
            this.Controls.Add(this.btn_Anime);
            this.Controls.Add(this.btn_Film);
            this.Controls.Add(this.btn_Musique);
            this.Name = "frm_accueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Musique;
        private System.Windows.Forms.Button btn_Film;
        private System.Windows.Forms.Button btn_Anime;
        private System.Windows.Forms.Button btn_Series;
    }
}

