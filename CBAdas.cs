using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBRadio
{
    class CBAdas
    {
        public int AdasIdejeOra { get; set; }
        public int AdasIdejePerc { get; set; }
        public int AdasSzam { get; set; }
        public string SoforNev { get; set; }



        public CBAdas() { }

        public CBAdas(int ora, int perc, int db, string nev) {

            AdasIdejeOra = ora;
            AdasIdejePerc = perc;
            AdasSzam = db;
            SoforNev = nev;
        }



        public CBAdas(string ido, int db, string nev)
        {
            string[] idoDarabok = ido.Split(':');
            AdasIdejeOra = Convert.ToInt32(idoDarabok[0]);
            AdasIdejePerc = Convert.ToInt32(idoDarabok[1]);
            AdasSzam = db;
            SoforNev = nev;
        }









    }
}
