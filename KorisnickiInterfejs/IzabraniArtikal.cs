using KontrolerKorisnickogInterfejsa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    public partial class IzabraniArtikal : Form
    {
        
        public IzabraniArtikal()
        {
            InitializeComponent();
            
        }

        private void IzabraniArtikal_Load(object sender, EventArgs e)
        {
          KontrolerKI.popuniPoljaArtikla(txtNaziv,txtCena,txtProizvodjac,txtRokTrajanja);
        }

        private void btnZapamti_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.zapamtiArtikal(txtNaziv, txtProizvodjac, txtRokTrajanja, txtCena)) this.Close();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.obrisiArtikal()) this.Close();
        }
    }
}
