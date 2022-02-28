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



namespace CBRadio
{
    public partial class FoAblak : Form
    {
        private List<CBAdas> cbAdasok;
        private string fajlNev;

        public FoAblak()
        {
            cbAdasok = new List<CBAdas>();
            fajlNev = "cb.txt";

            InitializeComponent();

        }

        private void FoAblak_Load(object sender, EventArgs e)
        {
            fajlBeolvasas(fajlNev);

            sofornevComboBox.Items.AddRange(soforok().ToArray());

        }


        private void fajlBeolvasas(string fajlNev)
        {
            try
            {
                using (StreamReader olvaso = new StreamReader(fajlNev))
                {
                    olvaso.ReadLine();

                    while (!olvaso.EndOfStream)
                    {
                        string[] sornyiAdat = olvaso.ReadLine().Split(';');
                        
                        CBAdas uj = new CBAdas(Convert.ToInt32(sornyiAdat[0]),
                            Convert.ToInt32(sornyiAdat[1]),
                            Convert.ToInt32(sornyiAdat[2]),
                            sornyiAdat[3]);

                        cbAdasok.Add(uj);
                        
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(this, $"Fájl olvasási hiba: {ex.Message}", "Fájlolvasási hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //MessageBox.Show($"Beolvasott sorok száma: {cbAdasok.Count}");

        }


        private List<string> soforok()
        {
            List<string> soforLista = new List<string>();

            foreach (CBAdas i in cbAdasok)
            {
                if(!soforLista.Contains(i.SoforNev))
                {
                    soforLista.Add(i.SoforNev);
                }
            }

            soforLista.Sort();

            return soforLista;
        }





    }
}
