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
            this.lbx_Anime = new System.Windows.Forms.ListBox();
            this.cbx_Anime = new System.Windows.Forms.ComboBox();
            this.pbx_Sharingan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Sharingan)).BeginInit();
            this.SuspendLayout();
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
            this.cbx_Anime.Location = new System.Drawing.Point(12, 16);
            this.cbx_Anime.Name = "cbx_Anime";
            this.cbx_Anime.Size = new System.Drawing.Size(151, 21);
            this.cbx_Anime.TabIndex = 3;
            // 
            // pbx_Sharingan
            // 
            this.pbx_Sharingan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbx_Sharingan.BackgroundImage")));
            this.pbx_Sharingan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbx_Sharingan.Location = new System.Drawing.Point(45, 209);
            this.pbx_Sharingan.Name = "pbx_Sharingan";
            this.pbx_Sharingan.Size = new System.Drawing.Size(83, 87);
            this.pbx_Sharingan.TabIndex = 5;
            this.pbx_Sharingan.TabStop = false;
            // 
            // frm_Anime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 412);
            this.Controls.Add(this.pbx_Sharingan);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Sharingan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbx_Anime;
        private System.Windows.Forms.ComboBox cbx_Anime;
        private System.Windows.Forms.PictureBox pbx_Sharingan;
    }
}