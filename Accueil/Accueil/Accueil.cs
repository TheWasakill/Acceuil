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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void btn_Musique_Click(object sender, EventArgs e)
        {
            frm_Musique l_AfficheMusique = new frm_Musique();
            l_AfficheMusique.Show();
        }

        private void btn_Film_Click(object sender, EventArgs e)
        {
            frm_Film l_AfficheFilm = new frm_Film();
            l_AfficheFilm.Show();
        }

        private void btn_Anime_Click(object sender, EventArgs e)
        {
            frm_Anime l_AfficheAnime = new frm_Anime();
            l_AfficheAnime.Show();
        }
    }
}
