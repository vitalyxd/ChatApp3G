using System.Windows.Forms;
using System;

namespace ChatApp3G
{
    public partial class KreiranjeKorisnika : Form
    {
        public KreiranjeKorisnika()
        {
            InitializeComponent();
        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button clicked!");
            // Prikaži podatke u ListBox-u
            string ime = textBox1.Text;
            string prezime = textBox2.Text;
            string email = textBox4.Text;
            string korisnickoIme = textBox5.Text;
            string password = textBox6.Text;

            // Provjera jesu li svi potrebni podaci uneseni
            if (string.IsNullOrWhiteSpace(ime) || 
                string.IsNullOrWhiteSpace(prezime) ||
                string.IsNullOrWhiteSpace(email) || 
                string.IsNullOrWhiteSpace(korisnickoIme) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Molimo popunite sve podatke.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kreiraj novi korisnik
            Korisnik noviKorisnik = new Korisnik(ime, prezime, email, korisnickoIme, password);

            // Dodaj korisnika u ListBox
            listBox1.Items.Add(noviKorisnik);

            // Očisti polja nakon dodavanja korisnika
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
