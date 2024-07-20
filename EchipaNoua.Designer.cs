namespace lab3
{
    partial class EchipaNoua
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
            this.button_creare = new System.Windows.Forms.Button();
            this.textBox_echipa = new System.Windows.Forms.TextBox();
            this.label_echipa = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // button_anulare
            // 
            this.button_anulare.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_anulare.Location = new System.Drawing.Point(12, 111);
            this.button_anulare.Name = "button_anulare";
            this.button_anulare.Size = new System.Drawing.Size(250, 43);
            this.button_anulare.TabIndex = 9;
            this.button_anulare.Text = "Anulare";
            this.button_anulare.UseVisualStyleBackColor = true;
            this.button_anulare.Click += new System.EventHandler(this.button_anulare_Click);
            // 
            // button_creare
            // 
            this.button_creare.Location = new System.Drawing.Point(12, 62);
            this.button_creare.Name = "button_creare";
            this.button_creare.Size = new System.Drawing.Size(250, 43);
            this.button_creare.TabIndex = 8;
            this.button_creare.Text = "Creare echipă";
            this.button_creare.UseVisualStyleBackColor = true;
            this.button_creare.Click += new System.EventHandler(this.button_creare_Click);
            // 
            // textBox_echipa
            // 
            this.textBox_echipa.Location = new System.Drawing.Point(12, 34);
            this.textBox_echipa.Name = "textBox_echipa";
            this.textBox_echipa.Size = new System.Drawing.Size(250, 22);
            this.textBox_echipa.TabIndex = 7;
            // 
            // label_echipa
            // 
            this.label_echipa.AutoSize = true;
            this.label_echipa.Location = new System.Drawing.Point(12, 15);
            this.label_echipa.Name = "label_echipa";
            this.label_echipa.Size = new System.Drawing.Size(123, 16);
            this.label_echipa.TabIndex = 6;
            this.label_echipa.Text = "Nume echipă nouă:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // EchipaNoua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 167);
            this.Controls.Add(this.button_anulare);
            this.Controls.Add(this.button_creare);
            this.Controls.Add(this.textBox_echipa);
            this.Controls.Add(this.label_echipa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EchipaNoua";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_anulare;
        private System.Windows.Forms.Button button_creare;
        private System.Windows.Forms.TextBox textBox_echipa;
        private System.Windows.Forms.Label label_echipa;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}