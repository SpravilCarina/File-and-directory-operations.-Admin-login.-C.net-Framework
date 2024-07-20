namespace lab3
{
    partial class JucatorNou
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
            this.button_anulare = new System.Windows.Forms.Button();
            this.button_adaugare = new System.Windows.Forms.Button();
            this.textBox_nume = new System.Windows.Forms.TextBox();
            this.label_nume = new System.Windows.Forms.Label();
            this.textBox_cnp = new System.Windows.Forms.TextBox();
            this.label_cnp = new System.Windows.Forms.Label();
            this.label_echipa = new System.Windows.Forms.Label();
            this.comboBox_echipa = new System.Windows.Forms.ComboBox();
            this.comboBox_pozitie = new System.Windows.Forms.ComboBox();
            this.label_pozitie = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // button_anulare
            // 
            this.button_anulare.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_anulare.Location = new System.Drawing.Point(12, 252);
            this.button_anulare.Name = "button_anulare";
            this.button_anulare.Size = new System.Drawing.Size(250, 43);
            this.button_anulare.TabIndex = 13;
            this.button_anulare.Text = "Anulare";
            this.button_anulare.UseVisualStyleBackColor = true;
            this.button_anulare.Click += new System.EventHandler(this.button_anulare_Click);
            // 
            // button_adaugare
            // 
            this.button_adaugare.Location = new System.Drawing.Point(12, 203);
            this.button_adaugare.Name = "button_adaugare";
            this.button_adaugare.Size = new System.Drawing.Size(250, 43);
            this.button_adaugare.TabIndex = 12;
            this.button_adaugare.Text = "Adăugare jucător";
            this.button_adaugare.UseVisualStyleBackColor = true;
            this.button_adaugare.Click += new System.EventHandler(this.button_adaugare_Click);
            // 
            // textBox_nume
            // 
            this.textBox_nume.Location = new System.Drawing.Point(12, 37);
            this.textBox_nume.Name = "textBox_nume";
            this.textBox_nume.Size = new System.Drawing.Size(250, 22);
            this.textBox_nume.TabIndex = 11;
            // 
            // label_nume
            // 
            this.label_nume.AutoSize = true;
            this.label_nume.Location = new System.Drawing.Point(12, 18);
            this.label_nume.Name = "label_nume";
            this.label_nume.Size = new System.Drawing.Size(114, 16);
            this.label_nume.TabIndex = 10;
            this.label_nume.Text = "Nume jucător nou:";
            // 
            // textBox_cnp
            // 
            this.textBox_cnp.Location = new System.Drawing.Point(12, 81);
            this.textBox_cnp.Name = "textBox_cnp";
            this.textBox_cnp.Size = new System.Drawing.Size(250, 22);
            this.textBox_cnp.TabIndex = 15;
            // 
            // label_cnp
            // 
            this.label_cnp.AutoSize = true;
            this.label_cnp.Location = new System.Drawing.Point(12, 62);
            this.label_cnp.Name = "label_cnp";
            this.label_cnp.Size = new System.Drawing.Size(38, 16);
            this.label_cnp.TabIndex = 14;
            this.label_cnp.Text = "CNP:";
            // 
            // label_echipa
            // 
            this.label_echipa.AutoSize = true;
            this.label_echipa.Location = new System.Drawing.Point(12, 106);
            this.label_echipa.Name = "label_echipa";
            this.label_echipa.Size = new System.Drawing.Size(52, 16);
            this.label_echipa.TabIndex = 16;
            this.label_echipa.Text = "Echipă:";
            // 
            // comboBox_echipa
            // 
            this.comboBox_echipa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_echipa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_echipa.FormattingEnabled = true;
            this.comboBox_echipa.Location = new System.Drawing.Point(12, 126);
            this.comboBox_echipa.Name = "comboBox_echipa";
            this.comboBox_echipa.Size = new System.Drawing.Size(250, 24);
            this.comboBox_echipa.TabIndex = 17;
            // 
            // comboBox_pozitie
            // 
            this.comboBox_pozitie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_pozitie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_pozitie.FormattingEnabled = true;
            this.comboBox_pozitie.Location = new System.Drawing.Point(12, 173);
            this.comboBox_pozitie.Name = "comboBox_pozitie";
            this.comboBox_pozitie.Size = new System.Drawing.Size(250, 24);
            this.comboBox_pozitie.TabIndex = 19;
            // 
            // label_pozitie
            // 
            this.label_pozitie.AutoSize = true;
            this.label_pozitie.Location = new System.Drawing.Point(12, 153);
            this.label_pozitie.Name = "label_pozitie";
            this.label_pozitie.Size = new System.Drawing.Size(50, 16);
            this.label_pozitie.TabIndex = 18;
            this.label_pozitie.Text = "Poziție:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // JucatorNou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 305);
            this.Controls.Add(this.comboBox_pozitie);
            this.Controls.Add(this.label_pozitie);
            this.Controls.Add(this.comboBox_echipa);
            this.Controls.Add(this.label_echipa);
            this.Controls.Add(this.textBox_cnp);
            this.Controls.Add(this.label_cnp);
            this.Controls.Add(this.button_anulare);
            this.Controls.Add(this.button_adaugare);
            this.Controls.Add(this.textBox_nume);
            this.Controls.Add(this.label_nume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JucatorNou";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_anulare;
        private System.Windows.Forms.Button button_adaugare;
        private System.Windows.Forms.TextBox textBox_nume;
        private System.Windows.Forms.Label label_nume;
        private System.Windows.Forms.TextBox textBox_cnp;
        private System.Windows.Forms.Label label_cnp;
        private System.Windows.Forms.Label label_echipa;
        private System.Windows.Forms.ComboBox comboBox_echipa;
        private System.Windows.Forms.ComboBox comboBox_pozitie;
        private System.Windows.Forms.Label label_pozitie;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}