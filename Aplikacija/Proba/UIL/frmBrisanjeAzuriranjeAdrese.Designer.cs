namespace Proba.UIL
{
    partial class frmBrisanjeAzuriranjeAdrese
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrisanjeAzuriranjeAdrese));
            this.cmbAdresa = new System.Windows.Forms.ComboBox();
            this.tbBroj = new System.Windows.Forms.TextBox();
            this.cmbUlica = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbAdresa
            // 
            this.cmbAdresa.FormattingEnabled = true;
            this.cmbAdresa.Location = new System.Drawing.Point(70, 137);
            this.cmbAdresa.Name = "cmbAdresa";
            this.cmbAdresa.Size = new System.Drawing.Size(237, 21);
            this.cmbAdresa.TabIndex = 0;
            this.cmbAdresa.SelectedIndexChanged += new System.EventHandler(this.cmbAdresa_SelectedIndexChanged);
            this.cmbAdresa.SelectedValueChanged += new System.EventHandler(this.cmbAdresa_SelectedValueChanged);
            // 
            // tbBroj
            // 
            this.tbBroj.Location = new System.Drawing.Point(182, 33);
            this.tbBroj.Name = "tbBroj";
            this.tbBroj.Size = new System.Drawing.Size(215, 22);
            this.tbBroj.TabIndex = 1;
            // 
            // cmbUlica
            // 
            this.cmbUlica.FormattingEnabled = true;
            this.cmbUlica.Location = new System.Drawing.Point(182, 84);
            this.cmbUlica.Name = "cmbUlica";
            this.cmbUlica.Size = new System.Drawing.Size(215, 24);
            this.cmbUlica.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(111, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "измени";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Proba.Properties.Resources.Delete_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(111, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "обриши";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbUlica);
            this.groupBox1.Controls.Add(this.tbBroj);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(456, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 147);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подаци о адреси";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Улица";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Број";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(199, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Брисање и ажурирање података о адреси";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Изаберите адресу";
            // 
            // frmBrisanjeAzuriranjeAdrese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 489);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbAdresa);
            this.Name = "frmBrisanjeAzuriranjeAdrese";
            this.Text = "Брисање и ажурирање података о адреси";
            this.Load += new System.EventHandler(this.frmBrisanjeAzuriranjeAdrese_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAdresa;
        private System.Windows.Forms.TextBox tbBroj;
        private System.Windows.Forms.ComboBox cmbUlica;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}