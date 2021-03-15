using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KontrolerKorisnickogInterfejsa;

namespace KorisnickiInterfejs
{
    public partial class PretragaArtikala : Form
    {
        public PretragaArtikala()
        {
            InitializeComponent();
            KontrolerKI.pretraziArtikle(txtKriterijum, dgvPretraga);
        }

        private void txtKriterijum_TextChanged(object sender, EventArgs e)
        {
            //KontrolerKI.pretraziArtikle(txtKriterijum, dgvPretraga);
             
        }

        private void txtKriterijum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KontrolerKI.pretraziArtikle(txtKriterijum, dgvPretraga);
            }
        }

        private void dgvPretraga_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (KontrolerKI.pretraziArtikal(dgvPretraga))
            {
                this.Hide();
                new IzabraniArtikal().ShowDialog();
                txtKriterijum_KeyDown(sender, new KeyEventArgs(Keys.Enter));
                this.Show();
            }
        }
    }
}
