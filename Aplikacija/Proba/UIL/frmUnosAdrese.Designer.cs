namespace Proba.UIL
{
    partial class frmUnosAdrese
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
            this.cmbUl = new System.Windows.Forms.ComboBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbUl
            // 
            this.cmbUl.FormattingEnabled = true;
            this.cmbUl.Location = new System.Drawing.Point(164, 148);
            this.cmbUl.Name = "cmbUl";
            this.cmbUl.Size = new System.Drawing.Size(208, 21);
            this.cmbUl.TabIndex = 0;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(164, 209);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(208, 20);
            this.tbAdresa.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Image = global::Proba.Properties.Resources.Button_Add_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(400, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "сачувај";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(92, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Унос адресе у евиденцију";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Изаберите улицу:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Унесите број:";
            // 
            // button2
            // 
            this.button2.Image = global::Proba.Properties.Resources.Log_Out_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(400, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "крај рада";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // frmUnosAdrese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 386);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.cmbUl);
            this.Name = "frmUnosAdrese";
            this.Text = "Унос адресе у евиденцију";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUl;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}