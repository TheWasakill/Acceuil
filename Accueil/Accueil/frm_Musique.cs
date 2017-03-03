using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accueil
{
    public partial class frm_Musique : Form
    {
        public frm_Musique()
        {
            InitializeComponent();
        }

        private void frm_Musique_Load(object sender, EventArgs e)
        {
            cbx_GenreMusique.Text = "Rock";
            lbl_Manga.Visible = false;
            cbx_Manga.Visible = false;
        }
        
        private void Oprening_Selected()
        {
            if(cbx_GenreMusique.SelectedItem == )
            {

            }
        }
    }
}
