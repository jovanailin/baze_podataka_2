namespace Proba.UIL
{
    partial class frmIsporuka
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbRacun = new System.Windows.Forms.ComboBox();
            this.cmbStatusIsporuke = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unos podataka o isporuci";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Izaberite racun za koji je vezana isporuka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Izaberite trenutni status isporuke:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Izaberite datum:";
            // 
            // cmbRacun
            // 
            this.cmbRacun.FormattingEnabled = true;
            this.cmbRacun.Location = new System.Drawing.Point(340, 162);
            this.cmbRacun.Name = "cmbRacun";
            this.cmbRacun.Size = new System.Drawing.Size(200, 21);
            this.cmbRacun.TabIndex = 4;
            // 
            // cmbStatusIsporuke
            // 
            this.cmbStatusIsporuke.FormattingEnabled = true;
            this.cmbStatusIsporuke.Location = new System.Drawing.Point(340, 208);
            this.cmbStatusIsporuke.Name = "cmbStatusIsporuke";
            this.cmbStatusIsporuke.Size = new System.Drawing.Size(200, 21);
            this.cmbStatusIsporuke.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(340, 261);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(662, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "sacuvaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(662, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "kraj rada";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmIsporuka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 446);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbStatusIsporuke);
            this.Controls.Add(this.cmbRacun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmIsporuka";
            this.Text = "Unos podataka o isporuci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbRacun;
        private System.Windows.Forms.ComboBox cmbStatusIsporuke;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}