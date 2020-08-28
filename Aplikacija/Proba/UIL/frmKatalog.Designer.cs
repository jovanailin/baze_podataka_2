namespace Proba.UIL
{
    partial class frmKatalog
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
            this.tbBrojKataloga = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbRokVazenja = new System.Windows.Forms.TextBox();
            this.tbNapomena = new System.Windows.Forms.TextBox();
            this.cmbKupac = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Број каталога:";
            // 
            // tbBrojKataloga
            // 
            this.tbBrojKataloga.Location = new System.Drawing.Point(291, 118);
            this.tbBrojKataloga.Name = "tbBrojKataloga";
            this.tbBrojKataloga.Size = new System.Drawing.Size(244, 20);
            this.tbBrojKataloga.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(291, 165);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // tbRokVazenja
            // 
            this.tbRokVazenja.Location = new System.Drawing.Point(291, 203);
            this.tbRokVazenja.Name = "tbRokVazenja";
            this.tbRokVazenja.Size = new System.Drawing.Size(244, 20);
            this.tbRokVazenja.TabIndex = 3;
            // 
            // tbNapomena
            // 
            this.tbNapomena.Location = new System.Drawing.Point(291, 249);
            this.tbNapomena.Name = "tbNapomena";
            this.tbNapomena.Size = new System.Drawing.Size(244, 20);
            this.tbNapomena.TabIndex = 4;
            // 
            // cmbKupac
            // 
            this.cmbKupac.FormattingEnabled = true;
            this.cmbKupac.Location = new System.Drawing.Point(291, 294);
            this.cmbKupac.Name = "cmbKupac";
            this.cmbKupac.Size = new System.Drawing.Size(244, 21);
            this.cmbKupac.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Proba.Properties.Resources.Button_Add_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(660, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "сачувај";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(166, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(456, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "Унос података о каталогу";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Датум издавања каталога:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(170, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Рок важења:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(182, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Напомена:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(115, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Купац коме се издаје:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Proba.Properties.Resources.Log_Out_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(660, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 33);
            this.button2.TabIndex = 12;
            this.button2.Text = "крај рада";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmKatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 493);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbKupac);
            this.Controls.Add(this.tbNapomena);
            this.Controls.Add(this.tbRokVazenja);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbBrojKataloga);
            this.Controls.Add(this.label1);
            this.Name = "frmKatalog";
            this.Text = "Унос података о каталогу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBrojKataloga;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbRokVazenja;
        private System.Windows.Forms.TextBox tbNapomena;
        private System.Windows.Forms.ComboBox cmbKupac;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}