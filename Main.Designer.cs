namespace lab3
{
    partial class Main
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
            this.comboBox_echipa = new System.Windows.Forms.ComboBox();
            this.button_echipaNoua = new System.Windows.Forms.Button();
            this.groupBox_echipa = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel_jucatori = new System.Windows.Forms.FlowLayoutPanel();
            this.button_jucatorNou = new System.Windows.Forms.Button();
            this.groupBox_jucator = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_dataNasterii = new System.Windows.Forms.DateTimePicker();
            this.textBox_varsta = new System.Windows.Forms.TextBox();
            this.textBox_cnp = new System.Windows.Forms.TextBox();
            this.textBox_pozitie = new System.Windows.Forms.TextBox();
            this.textBox_nume = new System.Windows.Forms.TextBox();
            this.label_varsta = new System.Windows.Forms.Label();
            this.label_dataNasterii = new System.Windows.Forms.Label();
            this.label_cnp = new System.Windows.Forms.Label();
            this.label_pozitie = new System.Windows.Forms.Label();
            this.label_nume = new System.Windows.Forms.Label();
            this.groupBox_echipa.SuspendLayout();
            this.groupBox_jucator.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_echipa
            // 
            this.comboBox_echipa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_echipa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_echipa.FormattingEnabled = true;
            this.comboBox_echipa.Location = new System.Drawing.Point(6, 21);
            this.comboBox_echipa.Name = "comboBox_echipa";
            this.comboBox_echipa.Size = new System.Drawing.Size(175, 24);
            this.comboBox_echipa.TabIndex = 1;
            this.comboBox_echipa.SelectedIndexChanged += new System.EventHandler(this.comboBox_echipa_SelectedIndexChanged);
            // 
            // button_echipaNoua
            // 
            this.button_echipaNoua.Location = new System.Drawing.Point(187, 22);
            this.button_echipaNoua.Name = "button_echipaNoua";
            this.button_echipaNoua.Size = new System.Drawing.Size(103, 24);
            this.button_echipaNoua.TabIndex = 2;
            this.button_echipaNoua.Text = "Echipă nouă";
            this.button_echipaNoua.UseVisualStyleBackColor = true;
            this.button_echipaNoua.Click += new System.EventHandler(this.button_echipaNoua_Click);
            // 
            // groupBox_echipa
            // 
            this.groupBox_echipa.Controls.Add(this.flowLayoutPanel_jucatori);
            this.groupBox_echipa.Controls.Add(this.comboBox_echipa);
            this.groupBox_echipa.Controls.Add(this.button_echipaNoua);
            this.groupBox_echipa.Location = new System.Drawing.Point(13, 13);
            this.groupBox_echipa.Name = "groupBox_echipa";
            this.groupBox_echipa.Size = new System.Drawing.Size(296, 425);
            this.groupBox_echipa.TabIndex = 3;
            this.groupBox_echipa.TabStop = false;
            this.groupBox_echipa.Text = "Echipa";
            // 
            // flowLayoutPanel_jucatori
            // 
            this.flowLayoutPanel_jucatori.Location = new System.Drawing.Point(6, 52);
            this.flowLayoutPanel_jucatori.Name = "flowLayoutPanel_jucatori";
            this.flowLayoutPanel_jucatori.Size = new System.Drawing.Size(284, 367);
            this.flowLayoutPanel_jucatori.TabIndex = 3;
            // 
            // button_jucatorNou
            // 
            this.button_jucatorNou.Location = new System.Drawing.Point(315, 273);
            this.button_jucatorNou.Name = "button_jucatorNou";
            this.button_jucatorNou.Size = new System.Drawing.Size(141, 32);
            this.button_jucatorNou.TabIndex = 4;
            this.button_jucatorNou.Text = "Jucător nou";
            this.button_jucatorNou.UseVisualStyleBackColor = true;
            this.button_jucatorNou.Click += new System.EventHandler(this.button_jucatorNou_Click);
            // 
            // groupBox_jucator
            // 
            this.groupBox_jucator.Controls.Add(this.dateTimePicker_dataNasterii);
            this.groupBox_jucator.Controls.Add(this.textBox_varsta);
            this.groupBox_jucator.Controls.Add(this.textBox_cnp);
            this.groupBox_jucator.Controls.Add(this.textBox_pozitie);
            this.groupBox_jucator.Controls.Add(this.textBox_nume);
            this.groupBox_jucator.Controls.Add(this.label_varsta);
            this.groupBox_jucator.Controls.Add(this.label_dataNasterii);
            this.groupBox_jucator.Controls.Add(this.label_cnp);
            this.groupBox_jucator.Controls.Add(this.label_pozitie);
            this.groupBox_jucator.Controls.Add(this.label_nume);
            this.groupBox_jucator.Location = new System.Drawing.Point(315, 13);
            this.groupBox_jucator.Name = "groupBox_jucator";
            this.groupBox_jucator.Size = new System.Drawing.Size(281, 254);
            this.groupBox_jucator.TabIndex = 5;
            this.groupBox_jucator.TabStop = false;
            this.groupBox_jucator.Text = "Detalii jucător";
            // 
            // dateTimePicker_dataNasterii
            // 
            this.dateTimePicker_dataNasterii.Enabled = false;
            this.dateTimePicker_dataNasterii.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_dataNasterii.Location = new System.Drawing.Point(99, 165);
            this.dateTimePicker_dataNasterii.Name = "dateTimePicker_dataNasterii";
            this.dateTimePicker_dataNasterii.Size = new System.Drawing.Size(161, 22);
            this.dateTimePicker_dataNasterii.TabIndex = 9;
            // 
            // textBox_varsta
            // 
            this.textBox_varsta.Enabled = false;
            this.textBox_varsta.Location = new System.Drawing.Point(60, 202);
            this.textBox_varsta.Name = "textBox_varsta";
            this.textBox_varsta.Size = new System.Drawing.Size(57, 22);
            this.textBox_varsta.TabIndex = 8;
            // 
            // textBox_cnp
            // 
            this.textBox_cnp.Enabled = false;
            this.textBox_cnp.Location = new System.Drawing.Point(60, 127);
            this.textBox_cnp.Name = "textBox_cnp";
            this.textBox_cnp.Size = new System.Drawing.Size(200, 22);
            this.textBox_cnp.TabIndex = 7;
            // 
            // textBox_pozitie
            // 
            this.textBox_pozitie.Enabled = false;
            this.textBox_pozitie.Location = new System.Drawing.Point(60, 87);
            this.textBox_pozitie.Name = "textBox_pozitie";
            this.textBox_pozitie.Size = new System.Drawing.Size(200, 22);
            this.textBox_pozitie.TabIndex = 6;
            // 
            // textBox_nume
            // 
            this.textBox_nume.Enabled = false;
            this.textBox_nume.Location = new System.Drawing.Point(60, 47);
            this.textBox_nume.Name = "textBox_nume";
            this.textBox_nume.Size = new System.Drawing.Size(200, 22);
            this.textBox_nume.TabIndex = 5;
            // 
            // label_varsta
            // 
            this.label_varsta.AutoSize = true;
            this.label_varsta.Location = new System.Drawing.Point(8, 205);
            this.label_varsta.Name = "label_varsta";
            this.label_varsta.Size = new System.Drawing.Size(49, 16);
            this.label_varsta.TabIndex = 4;
            this.label_varsta.Text = "Vârstă:";
            // 
            // label_dataNasterii
            // 
            this.label_dataNasterii.AutoSize = true;
            this.label_dataNasterii.Location = new System.Drawing.Point(8, 168);
            this.label_dataNasterii.Name = "label_dataNasterii";
            this.label_dataNasterii.Size = new System.Drawing.Size(85, 16);
            this.label_dataNasterii.TabIndex = 3;
            this.label_dataNasterii.Text = "Data nașterii:";
            // 
            // label_cnp
            // 
            this.label_cnp.AutoSize = true;
            this.label_cnp.Location = new System.Drawing.Point(19, 130);
            this.label_cnp.Name = "label_cnp";
            this.label_cnp.Size = new System.Drawing.Size(38, 16);
            this.label_cnp.TabIndex = 2;
            this.label_cnp.Text = "CNP:";
            // 
            // label_pozitie
            // 
            this.label_pozitie.AutoSize = true;
            this.label_pozitie.Location = new System.Drawing.Point(7, 90);
            this.label_pozitie.Name = "label_pozitie";
            this.label_pozitie.Size = new System.Drawing.Size(50, 16);
            this.label_pozitie.TabIndex = 1;
            this.label_pozitie.Text = "Poziție:";
            // 
            // label_nume
            // 
            this.label_nume.AutoSize = true;
            this.label_nume.Location = new System.Drawing.Point(11, 50);
            this.label_nume.Name = "label_nume";
            this.label_nume.Size = new System.Drawing.Size(46, 16);
            this.label_nume.TabIndex = 0;
            this.label_nume.Text = "Nume:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.groupBox_jucator);
            this.Controls.Add(this.button_jucatorNou);
            this.Controls.Add(this.groupBox_echipa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LPF";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox_echipa.ResumeLayout(false);
            this.groupBox_jucator.ResumeLayout(false);
            this.groupBox_jucator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_echipa;
        private System.Windows.Forms.Button button_echipaNoua;
        private System.Windows.Forms.GroupBox groupBox_echipa;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_jucatori;
        private System.Windows.Forms.Button button_jucatorNou;
        private System.Windows.Forms.GroupBox groupBox_jucator;
        private System.Windows.Forms.Label label_nume;
        private System.Windows.Forms.Label label_pozitie;
        private System.Windows.Forms.Label label_cnp;
        private System.Windows.Forms.Label label_dataNasterii;
        private System.Windows.Forms.Label label_varsta;
        private System.Windows.Forms.TextBox textBox_varsta;
        private System.Windows.Forms.TextBox textBox_cnp;
        private System.Windows.Forms.TextBox textBox_pozitie;
        private System.Windows.Forms.TextBox textBox_nume;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dataNasterii;
    }
}

