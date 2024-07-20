namespace lab3
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_utilizator = new System.Windows.Forms.Label();
            this.label_parola = new System.Windows.Forms.Label();
            this.textBox_utilizator = new System.Windows.Forms.TextBox();
            this.textBox_parola = new System.Windows.Forms.TextBox();
            this.button_autentificare = new System.Windows.Forms.Button();
            this.button_anulare = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_utilizator
            // 
            this.label_utilizator.AutoSize = true;
            this.label_utilizator.Location = new System.Drawing.Point(12, 9);
            this.label_utilizator.Name = "label_utilizator";
            this.label_utilizator.Size = new System.Drawing.Size(61, 16);
            this.label_utilizator.TabIndex = 0;
            this.label_utilizator.Text = "Utilizator:";
            // 
            // label_parola
            // 
            this.label_parola.AutoSize = true;
            this.label_parola.Location = new System.Drawing.Point(12, 64);
            this.label_parola.Name = "label_parola";
            this.label_parola.Size = new System.Drawing.Size(50, 16);
            this.label_parola.TabIndex = 1;
            this.label_parola.Text = "Parolă:";
            // 
            // textBox_utilizator
            // 
            this.textBox_utilizator.Location = new System.Drawing.Point(12, 28);
            this.textBox_utilizator.Name = "textBox_utilizator";
            this.textBox_utilizator.Size = new System.Drawing.Size(250, 22);
            this.textBox_utilizator.TabIndex = 2;
            // 
            // textBox_parola
            // 
            this.textBox_parola.Location = new System.Drawing.Point(12, 83);
            this.textBox_parola.Name = "textBox_parola";
            this.textBox_parola.PasswordChar = '*';
            this.textBox_parola.Size = new System.Drawing.Size(250, 22);
            this.textBox_parola.TabIndex = 3;
            // 
            // button_autentificare
            // 
            this.button_autentificare.Location = new System.Drawing.Point(12, 141);
            this.button_autentificare.Name = "button_autentificare";
            this.button_autentificare.Size = new System.Drawing.Size(250, 43);
            this.button_autentificare.TabIndex = 4;
            this.button_autentificare.Text = "Autentificare";
            this.button_autentificare.UseVisualStyleBackColor = true;
            this.button_autentificare.Click += new System.EventHandler(this.button_autentificare_Click);
            // 
            // button_anulare
            // 
            this.button_anulare.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_anulare.Location = new System.Drawing.Point(12, 190);
            this.button_anulare.Name = "button_anulare";
            this.button_anulare.Size = new System.Drawing.Size(250, 43);
            this.button_anulare.TabIndex = 5;
            this.button_anulare.Text = "Anulare";
            this.button_anulare.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 119);
            this.progressBar.Maximum = 20;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(250, 16);
            this.progressBar.TabIndex = 6;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_anulare;
            this.ClientSize = new System.Drawing.Size(274, 245);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.button_anulare);
            this.Controls.Add(this.button_autentificare);
            this.Controls.Add(this.textBox_parola);
            this.Controls.Add(this.textBox_utilizator);
            this.Controls.Add(this.label_parola);
            this.Controls.Add(this.label_utilizator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autentificare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_utilizator;
        private System.Windows.Forms.Label label_parola;
        private System.Windows.Forms.TextBox textBox_utilizator;
        private System.Windows.Forms.TextBox textBox_parola;
        private System.Windows.Forms.Button button_autentificare;
        private System.Windows.Forms.Button button_anulare;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
    }
}