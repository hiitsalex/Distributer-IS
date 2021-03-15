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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtSifra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                if (KontrolerKorisnickogInterfejsa.KontrolerKI.poveziSeNaServer())
                {
                    if (KontrolerKorisnickogInterfejsa.KontrolerKI.prijaviKorisnika(txtSifra.Text))
                    {
                        this.Hide();
                        new GlavnaForma().ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Logovanje nije uspesno!");
                        return;
                    }

                }
                else MessageBox.Show("Nije moguce povezivanje na server. Molimo vas pokusajte kasnije");
            }
        }
    }
}
