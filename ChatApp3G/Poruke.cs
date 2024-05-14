using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp3G
{
    public class Poruke : IComparable
    {
        private int id;
        private Korisnik posiljatelj;
        private Korisnik primatelj;
        private string poruka;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Korisnik Posiljatelj
        {
            get { return posiljatelj; }
            set { posiljatelj = value; }
        }

        public Korisnik Primatelj
        {
            get { return primatelj; }
            set { primatelj = value; }
        }

        public string Poruka
        {
            get { return poruka; }
            set { poruka = value; }
        }

        

        public int CompareTo(object obj)
        {
            int rez = this.id.CompareTo(((Poruke)obj).id);
            if (rez == 0) rez = this.posiljatelj.CompareTo(((Poruke)obj).posiljatelj);
            if (rez == 0) rez = this.primatelj.CompareTo(((Poruke)obj).primatelj);
            return rez;
        }
        public override string ToString()

            => Posiljatelj.ToString() + "," + Primatelj.ToString() + "," + Poruka + "->" + Id.ToString();
    }
}
