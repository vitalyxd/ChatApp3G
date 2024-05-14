using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ChatApp3G
{
    public partial class KreiranjeKorisnika : Form
    {
        public KreiranjeKorisnika()
        {
            InitializeComponent();
        }

        private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            // Prikaži podatke u ListBox-u
            string ime = textBox1.Text;
            string prezime = textBox2.Text;
            string email = textBox4.Text;
            string korisnickoIme = textBox5.Text;
            string password = textBox6.Text;

            // Kreiraj novi korisnik
            Korisnik noviKorisnik = new Korisnik
            {
                Ime = ime,
                Prezime = prezime,
                Email = email,
                Username = korisnickoIme
            };

            // Dodaj korisnika u ListBox
            listBoxKorisnici.Items.Add(noviKorisnik);

            
        }
    }
}
