using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Login : Form
    {
        const string user = "admin";
        const string pass = "admin";

        public Login()
        {
            InitializeComponent();
        }

        private void button_autentificare_Click(object sender, EventArgs e)
        {
            if (textBox_utilizator.Text != user || textBox_parola.Text != pass) MessageBox.Show("Utilizator sau parolă incorectă!");
            else timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < progressBar.Maximum) progressBar.Value++;
            else
            {
                timer.Stop();
                this.Close();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
