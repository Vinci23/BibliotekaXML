using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLBiblioteka
{
    internal class Knjiga
    {
        int knjiga_id;
        string autor, izdavac, naziv;

        public Knjiga(string autor, string naziv, string izdavac, int knjiga_id) 
        {
            this.knjiga_id = knjiga_id;
            this.autor = autor;
            this.izdavac = izdavac;
            this.naziv = naziv;
        }

        public int Knjiga_id { get => knjiga_id; set => knjiga_id = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Izdavac { get => izdavac; set => izdavac = value; }
        public string Naziv { get => naziv; set => naziv = value; }

        public override string ToString()
        {
            return "Naziv: " + naziv + " Autor: " + autor + "izdavac: " + izdavac;
        }
    }
}
