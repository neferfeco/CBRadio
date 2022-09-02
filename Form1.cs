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
        private string fajlNev, fajlFejlec;
        private int sorokSzama;


        public void Metodus()
        {


        }



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
                    fajlFejlec = olvaso.ReadLine();

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

            sorokSzama = cbAdasok.Count;
            //MessageBox.Show($"Beolvasott sorok száma: {sorokSzama}");
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

        private void mentesGomb_Click(object sender, EventArgs e)
        {
            bool hiba = false;
            string hibaUzenet = "";

            if(sofornevComboBox.SelectedIndex > 0)
            {
                if(adasidoEllenorzes(adasidoSzovegmezo.Text.Trim()))
                {
                    CBAdas uj = new CBAdas(
                        adasidoSzovegmezo.Text,
                        (int)adasszamLeptethetomezo.Value,
                        sofornevComboBox.SelectedItem.ToString());

                    cbAdasok.Add(uj);

                    sofornevComboBox.SelectedIndex = 0;
                    adasidoSzovegmezo.Text = "";
                    adasszamLeptethetomezo.Value = 1;

                } else
                {
                    hiba = true;
                    hibaUzenet = "Rossz időpont formátum!";
                }

            } else
            {
                hiba = true;
                hibaUzenet = "Nem választottál ki sofőrt!";
            }
                      
            
            if(hiba)
            {
                MessageBox.Show(this, hibaUzenet, "Hibás", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hiba = false;
                hibaUzenet = "";            
            }
        }

        private bool adasidoEllenorzes(string ido)
        {
            bool formatumOK = false;

            if(ido.Length >=3 && ido.Length<=5 && ido.Contains(":"))
            {
                string[] idoDarabok = ido.Split(':');

                if(Convert.ToInt32(idoDarabok[0]) < 24 &&
                    Convert.ToInt32(idoDarabok[1]) < 60)
                {
                    formatumOK = true;
                }
            } 

            return formatumOK;
        }

        private void mentesFajlbaGomb_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter iro = new StreamWriter(fajlNev, true))
                {
                    for (int i = sorokSzama; i < cbAdasok.Count; i++)
                    {
                        iro.WriteLine($"{cbAdasok[i].AdasIdejeOra};{cbAdasok[i].AdasIdejePerc};" +
                            $"{cbAdasok[i].AdasSzam};{cbAdasok[i].SoforNev}");
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(this, $"Fájl írás hiba: {ex.Message}", "Fájlművelet hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Adatmentés sikeres!");
        }

        private void keresesGomb_Click(object sender, EventArgs e)
        {
            List<string> talalatok = new List<string>();
            listBox.Items.Clear();
            soforTalalatCimke.Text = "";

            if (sofornevKeresoSzovegmezo.Text.Length != 0) {

                foreach (CBAdas i in cbAdasok)
                {
                    if (i.SoforNev == sofornevKeresoSzovegmezo.Text) {
                        talalatok.Add(String.Format("{0, 4}:{1, -3} {2, 8}", i.AdasIdejeOra, i.AdasIdejePerc, i.AdasSzam));
                    }
                }

                soforTalalatCimke.Text = sofornevKeresoSzovegmezo.Text + " adásainak listája:";
                listBox.Items.AddRange(talalatok.ToArray());

            } else {

                MessageBox.Show(this, "Hiányzó név!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
