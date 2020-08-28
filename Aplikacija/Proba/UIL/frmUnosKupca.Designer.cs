namespace Proba.UIL
{
    partial class frmUnosKupca
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
            this.tbNazivKupca = new System.Windows.Forms.TextBox();
            this.tbPIB = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.cmbAdresa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNazivKupca
            // 
            this.tbNazivKupca.Location = new System.Drawing.Point(274, 124);
            this.tbNazivKupca.Name = "tbNazivKupca";
            this.tbNazivKupca.Size = new System.Drawing.Size(248, 20);
            this.tbNazivKupca.TabIndex = 0;
            // 
            // tbPIB
            // 
            this.tbPIB.Location = new System.Drawing.Point(274, 177);
            this.tbPIB.Name = "tbPIB";
            this.tbPIB.Size = new System.Drawing.Size(248, 20);
            this.tbPIB.TabIndex = 1;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Image = global::Proba.Properties.Resources.Button_Add_icon;
            this.btnSacuvaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSacuvaj.Location = new System.Drawing.Point(573, 170);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(107, 41);
            this.btnSacuvaj.TabIndex = 6;
            this.btnSacuvaj.Text = "сачувај";
            this.btnSacuvaj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // cmbAdresa
            // 
            this.cmbAdresa.FormattingEnabled = true;
            this.cmbAdresa.Location = new System.Drawing.Point(274, 223);
            this.cmbAdresa.Name = "cmbAdresa";
            this.cmbAdresa.Size = new System.Drawing.Size(248, 21);
            this.cmbAdresa.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Назив купца:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "ПИБ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Адреса купца:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(112, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(504, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Унос података о купцу у евиденцију";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Image = global::Proba.Properties.Resources.Log_Out_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(641, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "крај рада";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmUnosKupca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 496);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAdresa);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.tbPIB);
            this.Controls.Add(this.tbNazivKupca);
            this.Name = "frmUnosKupca";
            this.Text = "Унос података о купцу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNazivKupca;
        private System.Windows.Forms.TextBox tbPIB;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ComboBox cmbAdresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}