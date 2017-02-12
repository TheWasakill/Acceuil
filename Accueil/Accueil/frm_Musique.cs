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
            if (cbx_GenreMusique.SelectedIndex == Convert.ToInt32("Opening"))
            {
                frm_Anime l_testcbx = new frm_Anime();
                l_testcbx.Show();
            }
        }
    }
}
