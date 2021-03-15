using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FormaServer : Form
    {
        Server s;
        public FormaServer()
        {
            InitializeComponent();
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            s = new Server();
            if (s.pokreniServer())
            {
                lblStatus.Text = "Server je pokrenut!";
                lblStatus.ForeColor = Color.Green;
                btnPokreni.Enabled = false;
                btnZaustavi.Enabled = true;
            }
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            if (Server.listaKorisnika.Count > 0) { MessageBox.Show("Postoje korisnici koji rade na sistemu. \nNe mozete da zaustavite server"); return; }
            if (s.ZaustaviServer())
            {
                lblStatus.Text = "Server je zaustavljen!";
                lblStatus.ForeColor = Color.Red;
                btnPokreni.Enabled = true;
                btnZaustavi.Enabled = false;

            }
        }
    }
}
