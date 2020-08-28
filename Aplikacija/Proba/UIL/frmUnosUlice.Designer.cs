namespace Proba.UIL
{
    partial class frmUnosUlice
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
            this.tbNazivUlice = new System.Windows.Forms.TextBox();
            this.cmbMesta = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNazivUlice
            // 
            this.tbNazivUlice.Location = new System.Drawing.Point(172, 109);
            this.tbNazivUlice.Name = "tbNazivUlice";
            this.tbNazivUlice.Size = new System.Drawing.Size(167, 20);
            this.tbNazivUlice.TabIndex = 0;
            // 
            // cmbMesta
            // 
            this.cmbMesta.FormattingEnabled = true;
            this.cmbMesta.Location = new System.Drawing.Point(172, 161);
            this.cmbMesta.Name = "cmbMesta";
            this.cmbMesta.Size = new System.Drawing.Size(162, 21);
            this.cmbMesta.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Image = global::Proba.Properties.Resources.Button_Add_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(376, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "упиши";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Упишите наѕив улице:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(32, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Изаберите град:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(125, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "Унос података о  улици\r\n у евиденцију";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Proba.Properties.Resources.Log_Out_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(395, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "крај рада";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmUnosUlice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbMesta);
            this.Controls.Add(this.tbNazivUlice);
            this.Name = "frmUnosUlice";
            this.Text = "Унос улице у евиденцију";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNazivUlice;
        private System.Windows.Forms.ComboBox cmbMesta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}