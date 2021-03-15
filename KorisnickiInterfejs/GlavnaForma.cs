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
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }

       

        private void unosArtiklaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UnosArtikla().ShowDialog();
            this.Show();
        }

        private void pretragaArtiklaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PretragaArtikala().ShowDialog();
            this.Show();
        }
    }
}
