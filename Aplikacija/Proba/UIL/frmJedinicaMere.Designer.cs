namespace Proba.UIL
{
    partial class frmJedinicaMere
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
            this.cmbBrisiJM = new System.Windows.Forms.ComboBox();
            this.tbIzmeniJM = new System.Windows.Forms.TextBox();
            this.tbNazivJM = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbBrisiJM
            // 
            this.cmbBrisiJM.FormattingEnabled = true;
            this.cmbBrisiJM.Location = new System.Drawing.Point(211, 185);
            this.cmbBrisiJM.Name = "cmbBrisiJM";
            this.cmbBrisiJM.Size = new System.Drawing.Size(121, 21);
            this.cmbBrisiJM.TabIndex = 0;
            this.cmbBrisiJM.SelectedValueChanged += new System.EventHandler(this.cmbBrisiJM_SelectedValueChanged);
            // 
            // tbIzmeniJM
            // 
            this.tbIzmeniJM.Location = new System.Drawing.Point(211, 242);
            this.tbIzmeniJM.Name = "tbIzmeniJM";
            this.tbIzmeniJM.Size = new System.Drawing.Size(121, 20);
            this.tbIzmeniJM.TabIndex = 1;
            // 
            // tbNazivJM
            // 
            this.tbNazivJM.Location = new System.Drawing.Point(211, 130);
            this.tbNazivJM.Name = "tbNazivJM";
            this.tbNazivJM.Size = new System.Drawing.Size(121, 20);
            this.tbNazivJM.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Proba.Properties.Resources.Button_Add_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(353, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 47);
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
            this.button2.Location = new System.Drawing.Point(353, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 35);
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
            this.button3.Location = new System.Drawing.Point(353, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "измени";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Унос података о јединицама мере у евиденцију";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::Proba.Properties.Resources.Log_Out_icon;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(398, 380);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "крај рада";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "јединица мере";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "иѕаберите јединицу мере";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Измени јединицу мере";
            // 
            // frmJedinicaMere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 446);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbNazivJM);
            this.Controls.Add(this.tbIzmeniJM);
            this.Controls.Add(this.cmbBrisiJM);
            this.Name = "frmJedinicaMere";
            this.Text = "Јединица мере";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBrisiJM;
        private System.Windows.Forms.TextBox tbIzmeniJM;
        private System.Windows.Forms.TextBox tbNazivJM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}