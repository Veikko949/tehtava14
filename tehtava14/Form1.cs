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

namespace tehtava14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tallena_button_Click(object sender, EventArgs e)
        {
            string teksti = System.IO.File.ReadAllText(@"C:\\Users\\veikko.pihlajamaa\\source\\repos\\nimet\\teskti.txt");
            teksti += paivakirj_textBox.Text;
            teksti += " " + DateTime.Now.ToString("DD.MM.yyyy HH:mm") + "\n";
            TextWriter txt = new StreamWriter("C:\\Users\\veikko.pihlajamaa\\source\\repos\\nimet\\teskti.txt");
            txt.Write(teksti);
            txt.Close();
            Application.Exit();
        }
    }
}
