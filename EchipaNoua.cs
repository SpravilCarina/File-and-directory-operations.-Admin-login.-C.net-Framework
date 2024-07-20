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

namespace lab3
{
    public partial class EchipaNoua : Form
    {
        public EchipaNoua()
        {
            InitializeComponent();
        }

        private void button_creare_Click(object sender, EventArgs e)
        {
            if (textBox_echipa.Text == "")
                errorProvider.SetError(textBox_echipa, "Numele echipei nu poate fi gol!");
            else if (Directory.Exists(Application.StartupPath + "\\..\\..\\Echipe\\" + textBox_echipa.Text))
                errorProvider.SetError(textBox_echipa, "Echipă deja existentă!");
            else
            {
                errorProvider.Clear();
                Directory.CreateDirectory(Application.StartupPath + "\\..\\..\\Echipe\\" + textBox_echipa.Text);
                DialogResult = DialogResult.OK;
            }
        }

        private void button_anulare_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
