namespace Proba.UIL
{
    partial class frmMestoBLL
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
            this.tbMesto = new System.Windows.Forms.TextBox();
            this.cmbBrisiMesto = new System.Windows.Forms.ComboBox();
            this.tbIzmeniMesto = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMesto
            // 
            this.tbMesto.Location = new System.Drawing.Point(212, 38);
            this.tbMesto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbMesto.Name = "tbMesto";
            this.tbMesto.Size = new System.Drawing.Size(188, 21);
            this.tbMesto.TabIndex = 0;
            // 
            // cmbBrisiMesto
            // 
            this.cmbBrisiMesto.FormattingEnabled = true;
            this.cmbBrisiMesto.Location = new System.Drawing.Point(212, 97);
            this.cmbBrisiMesto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbBrisiMesto.Name = "cmbBrisiMesto";
            this.cmbBrisiMesto.Size = new System.Drawing.Size(188, 23);
            this.cmbBrisiMesto.TabIndex = 1;
            this.cmbBrisiMesto.SelectedValueChanged += new System.EventHandler(this.cmbBrisiMesto_SelectedValueChanged);
            // 
            // tbIzmeniMesto
            // 
            this.tbIzmeniMesto.Location = new System.Drawing.Point(212, 154);
            this.tbIzmeniMesto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbIzmeniMesto.Name = "tbIzmeniMesto";
            this.tbIzmeniMesto.Size = new System.Drawing.Size(188, 21);
            this.tbIzmeniMesto.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Image = global::Proba.Properties.Resources.Log_Out_icon;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(483, 374);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 43);
            this.button4.TabIndex = 6;
            this.button4.Text = "излаз";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Image = global::Proba.Properties.Resources.pencil_icon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(483, 257);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "измени";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Image = global::Proba.Properties.Resources.Delete_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(483, 194);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 57);
            this.button2.TabIndex = 4;
            this.button2.Text = "обриши";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Image = global::Proba.Properties.Resources.Button_Add_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(483, 138);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "сачувај";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Унос, брисање и ажурирање података о местима";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Унесите назив места:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(26, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Иѕаберите место:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Унесите нови назив места:\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbIzmeniMesto);
            this.groupBox1.Controls.Add(this.cmbBrisiMesto);
            this.groupBox1.Controls.Add(this.tbMesto);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(13, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 208);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Место";
            // 
            // frmMestoBLL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 527);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMestoBLL";
            this.Text = "Шифарник Место";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMesto;
        private System.Windows.Forms.ComboBox cmbBrisiMesto;
        private System.Windows.Forms.TextBox tbIzmeniMesto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}