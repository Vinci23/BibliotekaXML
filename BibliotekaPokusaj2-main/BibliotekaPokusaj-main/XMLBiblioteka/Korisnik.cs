using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLBiblioteka
{
    internal class Korisnik
    {
        
        string email;
        string ime, prezime, godRod;
       
        

        public Korisnik(string email, string ime, string prezime, string godRod)
        {
           
            this.email = email;
            this.ime = ime;
            this.prezime = prezime;
            this.godRod = godRod;
            
            
        }

       
        public string Email { get => email; set => email = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string GodRod { get => godRod; set => godRod = value; }
        

        public override string ToString()
        {
            return "Ime: " + ime+ " Prezime: " + Prezime + "Email: "+ email; 
        }
    }
}
