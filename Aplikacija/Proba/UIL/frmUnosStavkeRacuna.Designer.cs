namespace Proba.UIL
{
    partial class frmUnosStavkiRacuna
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
            this.cmbRacun = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbBrojRacuna = new System.Windows.Forms.TextBox();
            this.tbDatumRacuna = new System.Windows.Forms.TextBox();
            this.cmbKupac = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRedniBroj = new System.Windows.Forms.TextBox();
            this.tbKolicina = new System.Windows.Forms.TextBox();
            this.cmbProizvod = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbJM = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbRacun
            // 
            this.cmbRacun.FormattingEnabled = true;
            this.cmbRacun.Location = new System.Drawing.Point(37, 31);
            this.cmbRacun.Name = "cmbRacun";
            this.cmbRacun.Size = new System.Drawing.Size(299, 21);
            this.cmbRacun.TabIndex = 0;
            this.cmbRacun.SelectedValueChanged += new System.EventHandler(this.cmbRacun_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbRacun);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(262, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "изаберите рачун";
            // 
            // tbBrojRacuna
            // 
            this.tbBrojRacuna.Location = new System.Drawing.Point(32, 49);
            this.tbBrojRacuna.Name = "tbBrojRacuna";
            this.tbBrojRacuna.Size = new System.Drawing.Size(100, 20);
            this.tbBrojRacuna.TabIndex = 2;
            // 
            // tbDatumRacuna
            // 
            this.tbDatumRacuna.Location = new System.Drawing.Point(196, 49);
            this.tbDatumRacuna.Name = "tbDatumRacuna";
            this.tbDatumRacuna.Size = new System.Drawing.Size(299, 20);
            this.tbDatumRacuna.TabIndex = 3;
            // 
            // cmbKupac
            // 
            this.cmbKupac.FormattingEnabled = true;
            this.cmbKupac.Location = new System.Drawing.Point(523, 49);
            this.cmbKupac.Name = "cmbKupac";
            this.cmbKupac.Size = new System.Drawing.Size(210, 21);
            this.cmbKupac.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbKupac);
            this.groupBox2.Controls.Add(this.tbDatumRacuna);
            this.groupBox2.Controls.Add(this.tbBrojRacuna);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(103, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(757, 102);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "подаци о рачуну";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(592, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Купац:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Датум издавања рачуна:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Број рачуна:";
            // 
            // tbRedniBroj
            // 
            this.tbRedniBroj.Location = new System.Drawing.Point(40, 69);
            this.tbRedniBroj.Name = "tbRedniBroj";
            this.tbRedniBroj.Size = new System.Drawing.Size(100, 20);
            this.tbRedniBroj.TabIndex = 6;
            // 
            // tbKolicina
            // 
            this.tbKolicina.Location = new System.Drawing.Point(836, 68);
            this.tbKolicina.Name = "tbKolicina";
            this.tbKolicina.Size = new System.Drawing.Size(100, 20);
            this.tbKolicina.TabIndex = 7;
            // 
            // cmbProizvod
            // 
            this.cmbProizvod.FormattingEnabled = true;
            this.cmbProizvod.Location = new System.Drawing.Point(204, 68);
            this.cmbProizvod.Name = "cmbProizvod";
            this.cmbProizvod.Size = new System.Drawing.Size(232, 21);
            this.cmbProizvod.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cmbJM);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cmbProizvod);
            this.groupBox3.Controls.Add(this.tbKolicina);
            this.groupBox3.Controls.Add(this.tbRedniBroj);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(95, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(942, 104);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ставка рачуна";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(600, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Јединица мере";
            // 
            // cmbJM
            // 
            this.cmbJM.FormattingEnabled = true;
            this.cmbJM.Location = new System.Drawing.Point(531, 69);
            this.cmbJM.Name = "cmbJM";
            this.cmbJM.Size = new System.Drawing.Size(234, 21);
            this.cmbJM.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(849, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Количина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Производ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Редни број";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Proba.Properties.Resources.Button_Add_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(506, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 54);
            this.button1.TabIndex = 10;
            this.button1.Text = "сачувај";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(257, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(374, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Унос ставке рачуна у евиденцију";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Proba.Properties.Resources.Log_Out_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(888, 484);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 38);
            this.button2.TabIndex = 12;
            this.button2.Text = "крај рада";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmUnosStavkiRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUnosStavkiRacuna";
            this.Text = "Унос ставке рачуна";
            this.Load += new System.EventHandler(this.frmUnosStavkiRacuna_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRacun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbBrojRacuna;
        private System.Windows.Forms.TextBox tbDatumRacuna;
        private System.Windows.Forms.ComboBox cmbKupac;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbRedniBroj;
        private System.Windows.Forms.TextBox tbKolicina;
        private System.Windows.Forms.ComboBox cmbProizvod;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbJM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}