namespace Accueil
{
    partial class frm_Anime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Anime));
            this.btn_ChercherAnime = new System.Windows.Forms.Button();
            this.lbx_Anime = new System.Windows.Forms.ListBox();
            this.cbx_Anime = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_ChercherAnime
            // 
            this.btn_ChercherAnime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ChercherAnime.BackgroundImage")));
            this.btn_ChercherAnime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ChercherAnime.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_ChercherAnime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChercherAnime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ChercherAnime.Location = new System.Drawing.Point(12, 43);
            this.btn_ChercherAnime.Name = "btn_ChercherAnime";
            this.btn_ChercherAnime.Size = new System.Drawing.Size(88, 88);
            this.btn_ChercherAnime.TabIndex = 5;
            this.btn_ChercherAnime.UseVisualStyleBackColor = true;
            // 
            // lbx_Anime
            // 
            this.lbx_Anime.FormattingEnabled = true;
            this.lbx_Anime.Location = new System.Drawing.Point(211, 16);
            this.lbx_Anime.MaximumSize = new System.Drawing.Size(211, 381);
            this.lbx_Anime.MinimumSize = new System.Drawing.Size(211, 381);
            this.lbx_Anime.Name = "lbx_Anime";
            this.lbx_Anime.Size = new System.Drawing.Size(211, 381);
            this.lbx_Anime.TabIndex = 4;
            // 
            // cbx_Anime
            // 
            this.cbx_Anime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Anime.FormattingEnabled = true;
            this.cbx_Anime.IntegralHeight = false;
            this.cbx_Anime.Items.AddRange(new object[] {
            "Rock",
            "Pop",
            "Electro",
            "Heavy Metal",
            "Opening"});
            this.cbx_Anime.Location = new System.Drawing.Point(12, 16);
            this.cbx_Anime.Name = "cbx_Anime";
            this.cbx_Anime.Size = new System.Drawing.Size(151, 21);
            this.cbx_Anime.TabIndex = 3;
            // 
            // frm_Anime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 412);
            this.Controls.Add(this.btn_ChercherAnime);
            this.Controls.Add(this.lbx_Anime);
            this.Controls.Add(this.cbx_Anime);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(450, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 450);
            this.Name = "frm_Anime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Anime";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ChercherAnime;
        private System.Windows.Forms.ListBox lbx_Anime;
        private System.Windows.Forms.ComboBox cbx_Anime;
    }
}