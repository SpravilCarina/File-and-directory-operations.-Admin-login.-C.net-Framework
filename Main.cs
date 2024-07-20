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
using System.Reflection.Emit;

namespace lab3
{
    public partial class Main : Form
    {
        string[] echipe;

        public Main()
        {
            InitializeComponent();
        }

        private void syncChanges()
        {
            comboBox_echipa.Items.Clear();
            echipe = Directory.EnumerateDirectories(Application.StartupPath + "\\..\\..\\Echipe").ToArray();
            foreach (string ent in echipe)
            {
                DirectoryInfo echipaInfo = new DirectoryInfo(ent);
                comboBox_echipa.Items.Add(echipaInfo.Name);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            if (login.ShowDialog() != DialogResult.OK) Application.Exit();
            syncChanges();
        }

        private void comboBox_echipa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ent = echipe[comboBox_echipa.SelectedIndex];
            string[] jucatori = Directory.EnumerateFiles(ent).ToArray();
            flowLayoutPanel_jucatori.Controls.Clear();
            foreach (string jucator in jucatori)
            {
                string cnp = Path.GetFileNameWithoutExtension(jucator);
                StreamReader strR = new StreamReader(jucator);
                string nume = strR.ReadLine();
                string pozitie = strR.ReadLine();
                strR.Close();

                Jucator j = new Jucator(cnp, nume, pozitie);
                Button btn = new Button();
                btn.Width = 200;
                btn.Text = nume;
                btn.Click += btn_Click;
                btn.Tag = j;
                flowLayoutPanel_jucatori.Controls.Add(btn);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Jucator jucator = (Jucator)btn.Tag;
            textBox_nume.Text = jucator.Nume;
            textBox_pozitie.Text = jucator.Poz;
            textBox_cnp.Text = jucator.Cnp;
            dateTimePicker_dataNasterii.Value = jucator.Data.Date;
            textBox_varsta.Text = jucator.Varsta.ToString();
        }

        private void button_echipaNoua_Click(object sender, EventArgs e)
        {
            EchipaNoua echipaNoua = new EchipaNoua();
            if (echipaNoua.ShowDialog() == DialogResult.OK)
            {
                syncChanges();
                MessageBox.Show("Echipă creată cu succes!");
            }
        }

        private void button_jucatorNou_Click(object sender, EventArgs e)
        {
            JucatorNou jucatorNou = new JucatorNou();
            if (jucatorNou.ShowDialog() == DialogResult.OK)
            {
                comboBox_echipa.SelectedIndex = 0;
                MessageBox.Show("Jucător adăugat cu succes!");
            }
        }
    }
}
