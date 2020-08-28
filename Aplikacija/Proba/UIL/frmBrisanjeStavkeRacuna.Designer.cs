namespace Proba.UIL
{
    partial class frmBrisanjeStavkeRacuna
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
            this.tbBrojRacuna = new System.Windows.Forms.TextBox();
            this.tbDatumRacuna = new System.Windows.Forms.TextBox();
            this.cmbKupac = new System.Windows.Forms.ComboBox();
            this.tbUkupno = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvStavkeRacuna = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbRedniBroj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbRacun
            // 
            this.cmbRacun.FormattingEnabled = true;
            this.cmbRacun.Location = new System.Drawing.Point(67, 39);
            this.cmbRacun.Name = "cmbRacun";
            this.cmbRacun.Size = new System.Drawing.Size(296, 21);
            this.cmbRacun.TabIndex = 0;
            this.cmbRacun.SelectedValueChanged += new System.EventHandler(this.cmbRacun_SelectedValueChanged_1);
            // 
            // tbBrojRacuna
            // 
            this.tbBrojRacuna.Location = new System.Drawing.Point(38, 44);
            this.tbBrojRacuna.Name = "tbBrojRacuna";
            this.tbBrojRacuna.Size = new System.Drawing.Size(100, 20);
            this.tbBrojRacuna.TabIndex = 1;
            // 
            // tbDatumRacuna
            // 
            this.tbDatumRacuna.Location = new System.Drawing.Point(181, 44);
            this.tbDatumRacuna.Name = "tbDatumRacuna";
            this.tbDatumRacuna.Size = new System.Drawing.Size(154, 20);
            this.tbDatumRacuna.TabIndex = 2;
            // 
            // cmbKupac
            // 
            this.cmbKupac.FormattingEnabled = true;
            this.cmbKupac.Location = new System.Drawing.Point(356, 43);
            this.cmbKupac.Name = "cmbKupac";
            this.cmbKupac.Size = new System.Drawing.Size(121, 21);
            this.cmbKupac.TabIndex = 3;
            // 
            // tbUkupno
            // 
            this.tbUkupno.Location = new System.Drawing.Point(559, 44);
            this.tbUkupno.Name = "tbUkupno";
            this.tbUkupno.Size = new System.Drawing.Size(150, 20);
            this.tbUkupno.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbRacun);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(249, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 90);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Изаберите рачун";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbUkupno);
            this.groupBox2.Controls.Add(this.cmbKupac);
            this.groupBox2.Controls.Add(this.tbDatumRacuna);
            this.groupBox2.Controls.Add(this.tbBrojRacuna);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(135, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 86);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Подаци о рачуну";
            // 
            // dgvStavkeRacuna
            // 
            this.dgvStavkeRacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeRacuna.Location = new System.Drawing.Point(144, 306);
            this.dgvStavkeRacuna.Name = "dgvStavkeRacuna";
            this.dgvStavkeRacuna.Size = new System.Drawing.Size(743, 150);
            this.dgvStavkeRacuna.TabIndex = 7;
            this.dgvStavkeRacuna.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStavkeRacuna_CellMouseClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(874, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "прикажи ставке";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(874, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "крај рада";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbRedniBroj
            // 
            this.tbRedniBroj.Location = new System.Drawing.Point(134, 28);
            this.tbRedniBroj.Name = "tbRedniBroj";
            this.tbRedniBroj.Size = new System.Drawing.Size(100, 20);
            this.tbRedniBroj.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Редни број:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Proba.Properties.Resources.Delete_icon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(359, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 32);
            this.button3.TabIndex = 12;
            this.button3.Text = "обриши";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tbRedniBroj);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(115, 475);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(473, 74);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Брисање ставке рачуна:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(613, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Укупно:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(392, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Купац:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(178, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Датум издавања рачуна:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Број рачуна:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(273, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 33);
            this.label3.TabIndex = 14;
            this.label3.Text = "Брисање ставке рачуна";
            // 
            // frmBrisanjeStavkeRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 595);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvStavkeRacuna);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBrisanjeStavkeRacuna";
            this.Text = "Брисање ставке рачуна";
            this.Load += new System.EventHandler(this.frmBrisanjeStavkeRacuna_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRacun;
        private System.Windows.Forms.TextBox tbBrojRacuna;
        private System.Windows.Forms.TextBox tbDatumRacuna;
        private System.Windows.Forms.ComboBox cmbKupac;
        private System.Windows.Forms.TextBox tbUkupno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvStavkeRacuna;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbRedniBroj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}