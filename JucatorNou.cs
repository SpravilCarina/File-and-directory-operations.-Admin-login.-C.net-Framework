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
    public partial class JucatorNou : Form
    {
        string[] pozitii = { "Portar", "Mijlocas", "Fundas", "Atacant" };
        string[] echipe = Directory.EnumerateDirectories(Application.StartupPath + "\\..\\..\\Echipe").ToArray();

        public JucatorNou()
        {
            InitializeComponent();
            comboBox_pozitie.Items.AddRange(pozitii);
            foreach (string ent in echipe)
            {
                DirectoryInfo echipaInfo = new DirectoryInfo(ent);
                comboBox_echipa.Items.Add(echipaInfo.Name);
            }
        }

        private void button_adaugare_Click(object sender, EventArgs e)
        {
            bool isOk = true;
            string nume = textBox_nume.Text;
            string cnp = textBox_cnp.Text;
            string echipa = comboBox_echipa.Text;
            string pozitie = comboBox_pozitie.Text;

            errorProvider.SetError(textBox_nume, null);
            if (nume == "")
            {
                errorProvider.SetError(textBox_nume, "Numele nu poate fi gol!");
                isOk = false;
            }
            errorProvider.SetError(textBox_cnp, null);
            if (cnp == "")
            {
                errorProvider.SetError(textBox_cnp, "CNP-ul nu poate fi gol!");
                isOk = false;
            }
            else
            {
                if (DataHandler.createDataNasterii(cnp).Year == 1)
                {
                    errorProvider.SetError(textBox_cnp, "CNP invalid!");
                    isOk = false;
                }
                foreach (string ent in echipe)
                {
                    if (File.Exists(ent + "\\" + cnp + ".lpf"))
                    {
                        errorProvider.SetError(textBox_cnp, "Jucător cu acest CNP deja existent!");
                        isOk = false;
                    }
                }
            }
            errorProvider.SetError(comboBox_echipa, null);
            if (!comboBox_echipa.Items.Contains(echipa))
            {
                errorProvider.SetError(comboBox_echipa, "Echipă inexistentă!");
                isOk = false;
            }
            errorProvider.SetError(comboBox_pozitie, null);
            if (!comboBox_pozitie.Items.Contains(pozitie))
            {
                errorProvider.SetError(comboBox_pozitie, "Poziție invalidă!");
                isOk = false;
            }
            
            if (isOk)
            {
                errorProvider.Clear();
                DataHandler.writeJucator(Application.StartupPath + "\\..\\..\\Echipe\\" + echipa + "\\", cnp, nume, pozitie);
                DialogResult = DialogResult.OK;
            }
        }

        private void button_anulare_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
