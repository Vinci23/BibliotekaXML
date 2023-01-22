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
    public partial class UnosKnjiga : Form
    {
        List<Knjiga> knjige = new List<Knjiga>();
        string dokument1 = "knjiga.xml";
        public UnosKnjiga()
        {
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            Knjiga knjiga = new Knjiga(txtAutor.Text, txtNaslov.Text, txtIzdavac.Text, Convert.ToInt32(txtID.Text));
            knjige.Add(knjiga);

            DialogResult upit = MessageBox.Show("Želite li upisati još knjiga?", "Upit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (upit == DialogResult.Yes)
            {

                txtAutor.Clear();
                txtNaslov.Clear();
                txtIzdavac.Clear();
                txtID.Clear();
            }

            else
            {

                if (File.Exists(dokument1))
                {
                    var KnjigeXML = XDocument.Load(dokument1);


                    foreach (Knjiga k in knjige)
                    {
                        var Knjiga = new XElement("Knjiga",
                        new XElement("Ime_i_prezime_autora", knjiga.Autor),
                        new XElement("Naslov", knjiga.Naziv),
                        new XElement("Izdavač", knjiga.Izdavac),
                        new XElement("Identifikator", knjiga.Knjiga_id));
                        KnjigeXML.Root.Add(Knjiga);
                    }
                    KnjigeXML.Save(dokument1);
                }

                else
                {
                    var KnjigeXML = new XDocument();
                    KnjigeXML.Add(new XElement("Knjige"));
                    foreach (Knjiga k in knjige)
                    {
                        var Knjiga = new XElement("Knjiga",
                        new XElement("Ime_i_prezime_autora", knjiga.Autor),
                        new XElement("Naslov", knjiga.Naziv),
                        new XElement("Izdavač", knjiga.Izdavac),
                        new XElement("Identifikator", knjiga.Knjiga_id));
                        KnjigeXML.Root.Add(Knjiga);
                    }

                    txtAutor.Clear();
                    txtNaslov.Clear();
                    txtIzdavac.Clear();
                    txtID.Clear();
                    KnjigeXML.Save(dokument1);

                }
            }
        }
    }
}
