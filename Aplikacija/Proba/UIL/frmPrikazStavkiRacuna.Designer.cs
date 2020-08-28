namespace Proba.UIL
{
    partial class frmPrikazStavkiRacuna
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
            this.cmbRacun = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbBrojRacuna = new System.Windows.Forms.TextBox();
            this.tbDatumRacuna = new System.Windows.Forms.TextBox();
            this.cmbKupac = new System.Windows.Forms.ComboBox();
            this.dgvStavkeRacuna = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbUkupno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Изаберите рачун од интереса";
            // 
            // cmbRacun
            // 
            this.cmbRacun.FormattingEnabled = true;
            this.cmbRacun.Location = new System.Drawing.Point(291, 29);
            this.cmbRacun.Name = "cmbRacun";
            this.cmbRacun.Size = new System.Drawing.Size(284, 24);
            this.cmbRacun.TabIndex = 1;
            this.cmbRacun.SelectedIndexChanged += new System.EventHandler(this.cmbRacun_SelectedIndexChanged);
            this.cmbRacun.SelectedValueChanged += new System.EventHandler(this.cmbRacun_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbRacun);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(93, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 88);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Изаберите рачун";
            // 
            // tbBrojRacuna
            // 
            this.tbBrojRacuna.Enabled = false;
            this.tbBrojRacuna.Location = new System.Drawing.Point(10, 43);
            this.tbBrojRacuna.Name = "tbBrojRacuna";
            this.tbBrojRacuna.Size = new System.Drawing.Size(166, 20);
            this.tbBrojRacuna.TabIndex = 3;
            // 
            // tbDatumRacuna
            // 
            this.tbDatumRacuna.Enabled = false;
            this.tbDatumRacuna.Location = new System.Drawing.Point(224, 43);
            this.tbDatumRacuna.Name = "tbDatumRacuna";
            this.tbDatumRacuna.Size = new System.Drawing.Size(158, 20);
            this.tbDatumRacuna.TabIndex = 4;
            // 
            // cmbKupac
            // 
            this.cmbKupac.Enabled = false;
            this.cmbKupac.FormattingEnabled = true;
            this.cmbKupac.Location = new System.Drawing.Point(438, 43);
            this.cmbKupac.Name = "cmbKupac";
            this.cmbKupac.Size = new System.Drawing.Size(121, 21);
            this.cmbKupac.TabIndex = 5;
            // 
            // dgvStavkeRacuna
            // 
            this.dgvStavkeRacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeRacuna.Location = new System.Drawing.Point(93, 222);
            this.dgvStavkeRacuna.Name = "dgvStavkeRacuna";
            this.dgvStavkeRacuna.Size = new System.Drawing.Size(549, 150);
            this.dgvStavkeRacuna.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(725, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "прикажи ставке";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(725, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "крај рада";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbUkupno);
            this.groupBox2.Controls.Add(this.cmbKupac);
            this.groupBox2.Controls.Add(this.tbDatumRacuna);
            this.groupBox2.Controls.Add(this.tbBrojRacuna);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(83, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(783, 93);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "подаци о рачуну";
            // 
            // tbUkupno
            // 
            this.tbUkupno.Enabled = false;
            this.tbUkupno.Location = new System.Drawing.Point(618, 44);
            this.tbUkupno.Name = "tbUkupno";
            this.tbUkupno.Size = new System.Drawing.Size(139, 20);
            this.tbUkupno.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Број рачуна:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Датум издавања рачуна:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Купац:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(657, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Укупно:";
            // 
            // frmPrikazStavkiRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 384);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvStavkeRacuna);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrikazStavkiRacuna";
            this.Text = "Приказ ставки рачуна";
            this.Load += new System.EventHandler(this.frmPrikazStavkiRacuna_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRacun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbBrojRacuna;
        private System.Windows.Forms.TextBox tbDatumRacuna;
        private System.Windows.Forms.ComboBox cmbKupac;
        private System.Windows.Forms.DataGridView dgvStavkeRacuna;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbUkupno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}