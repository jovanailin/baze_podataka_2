namespace Proba.UIL
{
    partial class frmBrisanjeAzuriranjeUlice
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
            this.cmbUlica = new System.Windows.Forms.ComboBox();
            this.tbNazivUlice = new System.Windows.Forms.TextBox();
            this.cmbMesto = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNazivMesta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbUlica
            // 
            this.cmbUlica.FormattingEnabled = true;
            this.cmbUlica.Location = new System.Drawing.Point(43, 122);
            this.cmbUlica.Name = "cmbUlica";
            this.cmbUlica.Size = new System.Drawing.Size(205, 21);
            this.cmbUlica.TabIndex = 0;
            this.cmbUlica.SelectedIndexChanged += new System.EventHandler(this.cmbUlica_SelectedIndexChanged);
            // 
            // tbNazivUlice
            // 
            this.tbNazivUlice.Location = new System.Drawing.Point(188, 46);
            this.tbNazivUlice.Name = "tbNazivUlice";
            this.tbNazivUlice.Size = new System.Drawing.Size(143, 24);
            this.tbNazivUlice.TabIndex = 1;
            // 
            // cmbMesto
            // 
            this.cmbMesto.FormattingEnabled = true;
            this.cmbMesto.Location = new System.Drawing.Point(188, 107);
            this.cmbMesto.Name = "cmbMesto";
            this.cmbMesto.Size = new System.Drawing.Size(143, 26);
            this.cmbMesto.TabIndex = 2;
            this.cmbMesto.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNazivMesta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbMesto);
            this.groupBox1.Controls.Add(this.tbNazivUlice);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(259, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 185);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "подаци о улици";
            // 
            // tbNazivMesta
            // 
            this.tbNazivMesta.Enabled = false;
            this.tbNazivMesta.Location = new System.Drawing.Point(188, 110);
            this.tbNazivMesta.Name = "tbNazivMesta";
            this.tbNazivMesta.Size = new System.Drawing.Size(143, 24);
            this.tbNazivMesta.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Назив места:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Назив улице:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Proba.Properties.Resources.pencil_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(71, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "измени";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Proba.Properties.Resources.Delete_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(71, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "обриши";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Изаберите улицу:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(150, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(411, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Брисање и ажурирање података о улици";
            // 
            // frmBrisanjeAzuriranjeUlice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 490);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbUlica);
            this.Name = "frmBrisanjeAzuriranjeUlice";
            this.Text = "Брисање и ажурирање података о улици";
            this.Load += new System.EventHandler(this.frmBrisanjeAzuriranjeUlice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUlica;
        private System.Windows.Forms.TextBox tbNazivUlice;
        private System.Windows.Forms.ComboBox cmbMesto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNazivMesta;
    }
}