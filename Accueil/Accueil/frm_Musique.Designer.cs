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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbx_Musique = new System.Windows.Forms.ListBox();
            this.btn_ChercherMusique = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Rock",
            "Pop",
            "Electro",
            "Heavy Metal",
            "Opening"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // lbx_Musique
            // 
            this.lbx_Musique.FormattingEnabled = true;
            this.lbx_Musique.Location = new System.Drawing.Point(198, 12);
            this.lbx_Musique.MaximumSize = new System.Drawing.Size(211, 381);
            this.lbx_Musique.MinimumSize = new System.Drawing.Size(211, 381);
            this.lbx_Musique.Name = "lbx_Musique";
            this.lbx_Musique.Size = new System.Drawing.Size(211, 381);
            this.lbx_Musique.TabIndex = 1;
            // 
            // btn_ChercherMusique
            // 
            this.btn_ChercherMusique.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_ChercherMusique.Location = new System.Drawing.Point(12, 39);
            this.btn_ChercherMusique.Name = "btn_ChercherMusique";
            this.btn_ChercherMusique.Size = new System.Drawing.Size(88, 43);
            this.btn_ChercherMusique.TabIndex = 2;
            this.btn_ChercherMusique.Text = "Recherche";
            this.btn_ChercherMusique.UseVisualStyleBackColor = true;
            // 
            // frm_Musique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(421, 411);
            this.Controls.Add(this.btn_ChercherMusique);
            this.Controls.Add(this.lbx_Musique);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(450, 450);
            this.MinimumSize = new System.Drawing.Size(386, 400);
            this.Name = "frm_Musique";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Musique";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox lbx_Musique;
        private System.Windows.Forms.Button btn_ChercherMusique;
    }
}