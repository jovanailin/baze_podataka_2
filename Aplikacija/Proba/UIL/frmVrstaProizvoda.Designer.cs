namespace Proba.UIL
{
    partial class frmVrstaProizvoda
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
            this.cmbBrisiVrstuProizvoda = new System.Windows.Forms.ComboBox();
            this.tbIzmeniVrstuProizvoda = new System.Windows.Forms.TextBox();
            this.tbVrstaProizvoda = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbBrisiVrstuProizvoda
            // 
            this.cmbBrisiVrstuProizvoda.FormattingEnabled = true;
            this.cmbBrisiVrstuProizvoda.Location = new System.Drawing.Point(185, 183);
            this.cmbBrisiVrstuProizvoda.Name = "cmbBrisiVrstuProizvoda";
            this.cmbBrisiVrstuProizvoda.Size = new System.Drawing.Size(121, 21);
            this.cmbBrisiVrstuProizvoda.TabIndex = 6;
            this.cmbBrisiVrstuProizvoda.SelectedValueChanged += new System.EventHandler(this.cmbBrisiKategoriju_SelectedValueChanged);
            // 
            // tbIzmeniVrstuProizvoda
            // 
            this.tbIzmeniVrstuProizvoda.Location = new System.Drawing.Point(190, 234);
            this.tbIzmeniVrstuProizvoda.Name = "tbIzmeniVrstuProizvoda";
            this.tbIzmeniVrstuProizvoda.Size = new System.Drawing.Size(121, 20);
            this.tbIzmeniVrstuProizvoda.TabIndex = 1;
            // 
            // tbVrstaProizvoda
            // 
            this.tbVrstaProizvoda.Location = new System.Drawing.Point(190, 141);
            this.tbVrstaProizvoda.Name = "tbVrstaProizvoda";
            this.tbVrstaProizvoda.Size = new System.Drawing.Size(121, 20);
            this.tbVrstaProizvoda.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Proba.Properties.Resources.Button_Add_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(327, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "сачувај";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Proba.Properties.Resources.Delete_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(327, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "обриши";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Proba.Properties.Resources.pencil_icon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(327, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "измени";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::Proba.Properties.Resources.Log_Out_icon;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(384, 354);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 30);
            this.button4.TabIndex = 7;
            this.button4.Text = "крај рада";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(60, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Подаци о врсти производа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Врста производа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Изаберите врсту";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Изменитеврсту";
            // 
            // frmVrstaProizvoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 433);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbVrstaProizvoda);
            this.Controls.Add(this.tbIzmeniVrstuProizvoda);
            this.Controls.Add(this.cmbBrisiVrstuProizvoda);
            this.Name = "frmVrstaProizvoda";
            this.Text = "Врста производа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBrisiVrstuProizvoda;
        private System.Windows.Forms.TextBox tbIzmeniVrstuProizvoda;
        private System.Windows.Forms.TextBox tbVrstaProizvoda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}