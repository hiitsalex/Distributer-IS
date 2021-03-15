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
    public partial class UnosArtikla : Form
    {
        public UnosArtikla()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.zapamtiArtikal(txtNaziv, txtProizvodjac, txtRokTrajanja, txtCena)) this.Close();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            KontrolerKI.kreirajArtikal(txtId, btnKreiraj, groupBox1);
        }
    }
}
