using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;


namespace XMLBiblioteka
{
    public partial class UnosKorisnika : Form
    {
        List<Korisnik> korisnici = new List<Korisnik>();
        string dokument = "korisnik.xml";
        public UnosKorisnika()
        {
            InitializeComponent();
        }

        private void btnUnosKorisnika2_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = new Korisnik(txtEmail.Text, txtIme.Text, txtPrezime.Text, dtpGodRod.Text);

            korisnici.Add(korisnik);

            DialogResult upit = MessageBox.Show("Želite li upisati još osoba?", "Upit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (upit == DialogResult.Yes)
            {

                txtIme.Clear();
                txtPrezime.Clear();
                txtEmail.Clear();
            }

            else
            {

                if (File.Exists(dokument))
                {
                    var OsobeXML = XDocument.Load(dokument);


                    foreach (Korisnik k in korisnici)
                    {
                        var Osoba = new XElement("Osoba",
                        new XElement("Ime", korisnik.Ime),
                        new XElement("Prezime", korisnik.Prezime),
                        new XElement("Godina_Rođenja", korisnik.GodRod));
                        OsobeXML.Root.Add(Osoba);
                    }
                    OsobeXML.Save(dokument);
                }

                else
                {
                    var OsobeXML = new XDocument();
                    OsobeXML.Add(new XElement("Osobe"));
                    foreach (Korisnik k in korisnici)
                    {
                        var Osoba = new XElement("Osoba",
                        new XElement("Ime", korisnik.Ime),
                        new XElement("Prezime", korisnik.Prezime),
                        new XElement("Godina_Rođenja", korisnik.GodRod));
                        OsobeXML.Root.Add(Osoba);
                    }

                    txtIme.Clear();
                    txtPrezime.Clear();
                    txtEmail.Clear();
                    OsobeXML.Save(dokument);

                }
            }
        }
    }
}
