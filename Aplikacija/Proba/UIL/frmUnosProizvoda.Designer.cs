namespace Proba.UIL
{
    partial class frmUnosProizvoda
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
            this.tbNazivProizvoda = new System.Windows.Forms.TextBox();
            this.tbSifraProizvoda = new System.Windows.Forms.TextBox();
            this.tbPodsifraProizvoda = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbVrstaProizvoda = new System.Windows.Forms.ComboBox();
            this.tbMasa = new System.Windows.Forms.TextBox();
            this.cmbJedinicaMere = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNazivProizvoda
            // 
            this.tbNazivProizvoda.Location = new System.Drawing.Point(211, 139);
            this.tbNazivProizvoda.Name = "tbNazivProizvoda";
            this.tbNazivProizvoda.Size = new System.Drawing.Size(190, 20);
            this.tbNazivProizvoda.TabIndex = 0;
            // 
            // tbSifraProizvoda
            // 
            this.tbSifraProizvoda.Location = new System.Drawing.Point(211, 185);
            this.tbSifraProizvoda.Name = "tbSifraProizvoda";
            this.tbSifraProizvoda.Size = new System.Drawing.Size(190, 20);
            this.tbSifraProizvoda.TabIndex = 1;
            // 
            // tbPodsifraProizvoda
            // 
            this.tbPodsifraProizvoda.Location = new System.Drawing.Point(211, 247);
            this.tbPodsifraProizvoda.Name = "tbPodsifraProizvoda";
            this.tbPodsifraProizvoda.Size = new System.Drawing.Size(190, 20);
            this.tbPodsifraProizvoda.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Proba.Properties.Resources.Button_Add_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(444, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "сачувај";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Proba.Properties.Resources.Log_Out_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(437, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "крај рада";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(206, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Унос производа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Назив производа:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Шифра производа:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Подшифра производа:";
            // 
            // cmbVrstaProizvoda
            // 
            this.cmbVrstaProizvoda.FormattingEnabled = true;
            this.cmbVrstaProizvoda.Location = new System.Drawing.Point(211, 97);
            this.cmbVrstaProizvoda.Name = "cmbVrstaProizvoda";
            this.cmbVrstaProizvoda.Size = new System.Drawing.Size(190, 21);
            this.cmbVrstaProizvoda.TabIndex = 9;
            // 
            // tbMasa
            // 
            this.tbMasa.Location = new System.Drawing.Point(215, 295);
            this.tbMasa.Name = "tbMasa";
            this.tbMasa.Size = new System.Drawing.Size(186, 20);
            this.tbMasa.TabIndex = 10;
            // 
            // cmbJedinicaMere
            // 
            this.cmbJedinicaMere.FormattingEnabled = true;
            this.cmbJedinicaMere.Location = new System.Drawing.Point(219, 345);
            this.cmbJedinicaMere.Name = "cmbJedinicaMere";
            this.cmbJedinicaMere.Size = new System.Drawing.Size(182, 21);
            this.cmbJedinicaMere.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Врста производа:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Маса производа:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Јединица мере:";
            // 
            // frmUnosProizvoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 432);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbJedinicaMere);
            this.Controls.Add(this.tbMasa);
            this.Controls.Add(this.cmbVrstaProizvoda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbPodsifraProizvoda);
            this.Controls.Add(this.tbSifraProizvoda);
            this.Controls.Add(this.tbNazivProizvoda);
            this.Name = "frmUnosProizvoda";
            this.Text = "Унос производа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNazivProizvoda;
        private System.Windows.Forms.TextBox tbSifraProizvoda;
        private System.Windows.Forms.TextBox tbPodsifraProizvoda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbVrstaProizvoda;
        private System.Windows.Forms.TextBox tbMasa;
        private System.Windows.Forms.ComboBox cmbJedinicaMere;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}