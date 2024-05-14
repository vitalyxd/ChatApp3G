using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp3G
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class PodatkovniKontekst
    {
        private List<Korisnik> korisnici;
        private List<Poruka> poruke;
        private List<Razgovor> razgovori;

        public List<Korisnik> Korisnici { get { return this.korisnici; } }
        public List<Poruka> Poruke { get { return this.poruke; } }
        public List<Razgovor> Razgovori { get { return this.razgovori; } }

        private string datKorisnici = "korisnici.dat";
        private string datPoruke = "poruke.dat";
        private string datRazgovori = "razgovori.dat";

        public PodatkovniKontekst()
        {
            this.korisnici = UcitajKorisnike();
            this.poruke = UcitajPoruke();
            this.razgovori = UcitajRazgovore();
        }

        private List<Korisnik> UcitajKorisnike()
        {
            List<Korisnik> korisnici = new List<Korisnik>();
            if (File.Exists(datKorisnici))
            {
                using (StreamReader sr = new StreamReader(datKorisnici))
                {
                    while (!sr.EndOfStream)
                    {
                        string linija = sr.ReadLine();
                        string[] polja = linija.Split('|');
                        Korisnik k = new Korisnik();
                        k.Id = int.Parse(polja[0]);
                        k.Ime = polja[1];
                        k.Prezime = polja[2];
                        k.Email = polja[3];
                        k.Username = polja[4];
                        k.Password = polja[5];
                        korisnici.Add(k);
                    }
                }
            }
            return korisnici;
        }

        private List<Poruka> UcitajPoruke()
        {
            List<Poruka> poruke = new List<Poruka>();
            if (File.Exists(datPoruke))
            {
                using (StreamReader sr = new StreamReader(datPoruke))
                {
                    while (!sr.EndOfStream)
                    {
                        string linija = sr.ReadLine();
                        string[] polja = linija.Split('|');
                        Poruka p = new Poruka();
                        p.Id = int.Parse(polja[0]);
                        poruke.Add(p);
                    }
                }
            }
            return poruke;
        }

        private List<Razgovor> UcitajRazgovore()
        {
            List<Razgovor> razgovori = new List<Razgovor>();
            if (File.Exists(datRazgovori))
            {
                using (StreamReader sr = new StreamReader(datRazgovori))
                {
                    while (!sr.EndOfStream)
                    {
                        string linija = sr.ReadLine();
                        string[] polja = linija.Split('|');
                        Razgovor r = new Razgovor();
                        r.Id = int.Parse(polja[0]);
                        razgovori.Add(r);
                    }
                }
            }
            return razgovori;
        }

        public void SpremiKorisnike()
        {
            using (StreamWriter sw = new StreamWriter(datKorisnici))
            {
                foreach (Korisnik k in this.Korisnici)
                {
                    sw.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}",
                        k.Id, k.Ime, k.Prezime, k.Email, k.Username, k.Password);
                }
            }
        }

        public void SpremiPoruke()
        {
            using (StreamWriter sw = new StreamWriter(datPoruke))
            {
                foreach (Poruka p in this.Poruke)
                {
                    sw.WriteLine("{0}|{1}|{2}", p.Id,);
                }
            }
        }

        public void SpremiRazgovore()
        {
            using (StreamWriter sw = new StreamWriter(datRazgovori))
            {
                foreach (Razgovor r in this.Razgovori)
                {
                    sw.WriteLine("{0}|{1}|{2}", r.Id,);
                }
            }
        }
    }

    public class Korisnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class Poruka
    {
        public int Id { get; set; }
        
    }

    public class Razgovor
    {
        public int Id { get; set; }
        
    }

}
