using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Zamestnanec
    {
        string titul;
        string jmeno;
        int mesicniplat;
        DateTime datumnastupu;
        int ohodnoceni;
        int odpracovanehodiny;
        string pozice = "pracovník";
        public Zamestnanec(string titul, string jmeno, int mesicniplat, DateTime datumnastupu, int ohodnoceni, int odpracovanehodiny)
        {
            this.titul = titul;
            this.jmeno = jmeno;
            this.mesicniplat = mesicniplat;
            this.datumnastupu = datumnastupu;
            this.ohodnoceni = 0;
            this.odpracovanehodiny = 0;
        }
        public string Jmeno
        {
            get
            {
                if (jmeno[0] < 'A' || jmeno[0] > 'Z')
                {
                    jmeno = (char)(jmeno[0] + 32) + jmeno.Substring(1);
                }
                string[] jmenoaprijmeni = jmeno.Split(' ');
                jmenoaprijmeni[1] = jmenoaprijmeni[1].ToUpper();
                return jmenoaprijmeni[0] + " " + jmenoaprijmeni[1];
            }
            set
            {
                jmeno = value;

            }
        }
        public string Titul
        {
            get
            {
                if (titul[0] < 'A' || titul[0] > 'Z')
                {
                    titul = (char)(titul[0] + 32) + titul.Substring(1) + '.';
                }
                return titul;
            }
            set
            {
                titul = value;
            }
        }
        public int Rocniplat()
        {
            return 12 * mesicniplat + ohodnoceni;
        }
        public int Pocetmesicu()
        {
            TimeSpan cc = new TimeSpan();
            cc = DateTime.Now - datumnastupu;
            return (int)cc.TotalDays / 30;
        }
        public int Celkem()
        {
            return Pocetmesicu() * mesicniplat;
        }
        public void ZvysOhodnoceni()
        {
            ohodnoceni += 100;
            if (ohodnoceni > 10000)
            {
                pozice = "vedoucí";
            }
        }
        public int PridejOdpracovaneHodiny()
        {
            odpracovanehodiny++;           
            return odpracovanehodiny;
        }
        public int Relaxace(int hodinrelaxace)
        {
            return hodinrelaxace;
        }
        public override string ToString()
        {
            return "Titul: " + titul + "\nJméno: " + jmeno + "\nMěsíční plat: " + mesicniplat + "\nPočet měsíců v práci: " + Pocetmesicu() + "\nOsobní ohodnoceni: " + ohodnoceni + "\nRoční plat: " + Rocniplat() + "\nCelkový plat: " + Celkem() + "\nPočet odpracovaných hodin: " + odpracovanehodiny + "\nPozice: " + pozice;
        }
    }
}
