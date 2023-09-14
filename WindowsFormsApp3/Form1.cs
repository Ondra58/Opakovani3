using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Zamestnanec zamestnanec;
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            string titul = "Ing.";
            string jmeno = "Ondřej Zelený";
            int mesicniplat = 50000;
            DateTime datumnastupu = dateTimePicker1.Value;
            int ohodnoceni = 1000;
            int odpracovanehodiny = 10;
            zamestnanec = new Zamestnanec(titul, jmeno, mesicniplat, datumnastupu, ohodnoceni, odpracovanehodiny);
            MessageBox.Show(zamestnanec.ToString(), "Info");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zamestnanec.ZvysOhodnoceni();
            MessageBox.Show(zamestnanec.ToString(), "Info");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zamestnanec.PridejOdpracovaneHodiny();
            MessageBox.Show(zamestnanec.ToString(), "Info");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            zamestnanec.Relaxace((int)numericUpDown1.Value);
            MessageBox.Show(zamestnanec.ToString(), "Info");
        }
    }
}
