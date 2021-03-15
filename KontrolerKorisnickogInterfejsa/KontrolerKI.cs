using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteka;
using Komunikacija;

namespace KontrolerKorisnickogInterfejsa
{
    public class KontrolerKI
    {
        public static Komunikacija.Komunikacija komunikacija;
        public static Artikal artikal;
        public static Korisnik korisnik;
        


        public static bool poveziSeNaServer()
        {
            if(komunikacija==null) komunikacija = new Komunikacija.Komunikacija();
            return komunikacija.poveziSeNaServer();
        }

        public static void popuniPoljaArtikla(TextBox txtNaziv, TextBox txtCena, TextBox txtProizvodjac, TextBox txtRokTrajanja)
        {
            txtNaziv.Text = artikal.Naziv;
            txtProizvodjac.Text = artikal.Proizvodjac;
            txtCena.Text = artikal.Cena.ToString();
            txtRokTrajanja.Text = artikal.RokTrajanja.ToString("dd.MM.yyyy");
        }

        public static bool prijaviKorisnika(string sifra)
        {
            korisnik = new Korisnik(); 
            korisnik.SID = sifra;
            korisnik = komunikacija.nadjiKorisnika(korisnik) as Korisnik;
            if (korisnik == null)
            {
                MessageBox.Show("Niste uneli ispravnu sifru!");
                return false;
            }
            return true;


        }

        public static bool obrisiArtikal()
        {
            DialogResult dijalog = MessageBox.Show("Jeste li sigurni da zelite da obrisete artikal?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dijalog)
            {
             
                case DialogResult.Yes:
                    object rezultat = komunikacija.obrisiArtikal(artikal);
                    if (rezultat == null)
                    {
                        MessageBox.Show("Sistem ne moze da obrise artikal");
                        return false;
                    }

                    MessageBox.Show("Sistem je uspesno obrisao artikal");
                    return true;
                default: return false;
               
            }
        
        }

        public static void pretraziArtikle(TextBox txtKriterijum, DataGridView dgvPretraga)
        {
            
            artikal = new Artikal();
            artikal.USLOV = "Naziv like '%"+txtKriterijum.Text+ "%' or Proizvodjac like '%" + txtKriterijum.Text + "%'";
            List<Artikal> lista  = (List<Artikal>)komunikacija.pretraziArtikle(artikal);
            if (lista == null)
            {
                MessageBox.Show("Sistem ne moze da pronadje artikle");
                return;

            }
            dgvPretraga.DataSource = lista;
            if (lista.Count == 0)
            {
                MessageBox.Show("Ne postoje artikli za odabrani kriterijum.");
                return;

            }
            MessageBox.Show("Sistem je uspesno pronasao artikle");

        }

        public static bool pretraziArtikal(DataGridView dgvPretraga)
        {
            try
            {
                artikal = dgvPretraga.CurrentRow.DataBoundItem as Artikal;
               artikal = komunikacija.pretraziArtikal(artikal) as Artikal;
                if (artikal == null)
                {
                    MessageBox.Show("Sistem ne moze da pronadje artikal");
                    return false;
                }
                MessageBox.Show("Sistem je uspesno pronasao artikal");
                return true;

            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali artikal za prikaz");
                return false;
            }
        }

        public static bool zapamtiArtikal(TextBox txtNaziv, TextBox txtProizvodjac, TextBox txtRokTrajanja, TextBox txtCena)
        {
            artikal.Naziv = txtNaziv.Text;
            artikal.Proizvodjac = txtProizvodjac.Text;

            try
            {
                artikal.RokTrajanja = DateTime.ParseExact(txtRokTrajanja.Text, "dd.MM.yyyy", null);

            }
            catch (Exception)
            {

                MessageBox.Show("Niste uneli datum u dobrom formatu");
                return false;
            }

            try
            {
                artikal.Cena = Convert.ToDouble(txtCena.Text);

            }
            catch (Exception)
            {

                MessageBox.Show("Niste uneli cenu u dobrom formatu");
                return false;
            }


            DialogResult dijalog = MessageBox.Show("Jeste li sigurni da zelite da izmenite artikal?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dijalog)
            {

                case DialogResult.Yes:
                    object rezultat = komunikacija.zapamtiArtikal(artikal);
                    if (rezultat == null)
                    {
                        MessageBox.Show("Sistem ne moze da zapamti artikal");
                        return false;
                    }

                    MessageBox.Show("Sistem je uspesno zapamtio artikal");
                    return true;
                default: return false;

            }
          

        }

        public void kraj()
        {
            komunikacija.kraj();
            komunikacija = null;
        }

        public static void kreirajArtikal(TextBox txtId, Button btnKreiraj, GroupBox groupBox1)
        {
            artikal = komunikacija.kreirajArtikal() as Artikal;
            if (artikal == null)
            {
                MessageBox.Show("Sistem ne moze da kreira novi artikal");
            }else
            {
                MessageBox.Show("Sistem je kreirao novi artikal");
                groupBox1.Enabled = true;
                txtId.Text = artikal.Id.ToString();
                btnKreiraj.Enabled = false;
            }
        }
    }
}
