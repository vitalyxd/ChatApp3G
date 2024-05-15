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
            // Prikaži podatke u ListBox-u
            string ime = textBox1.Text;
            string prezime = textBox2.Text;
            string email = textBox4.Text;
            string korisnickoIme = textBox5.Text;
            string password = textBox6.Text;

            // Kreiraj novi korisnik
            Korisnik noviKorisnik = new Korisnik
            (ime, prezime, email, korisnickoIme, password);

            // Dodaj korisnika u ListBox
            listBox1.Items.Add(noviKorisnik);

            
        }
    }
}
