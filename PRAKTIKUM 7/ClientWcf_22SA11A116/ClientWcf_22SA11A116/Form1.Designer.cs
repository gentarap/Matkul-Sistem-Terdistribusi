namespace ClientWcf_22SA11A116
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.buttontambah = new System.Windows.Forms.Button();
            this.buttonkurang = new System.Windows.Forms.Button();
            this.buttonkali = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angka A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angka B";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasil";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(122, 50);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(151, 22);
            this.txtA.TabIndex = 3;
            this.txtA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(122, 93);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(151, 22);
            this.txtB.TabIndex = 4;
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(122, 136);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(151, 22);
            this.txtHasil.TabIndex = 5;
            // 
            // buttontambah
            // 
            this.buttontambah.BackColor = System.Drawing.Color.Turquoise;
            this.buttontambah.Location = new System.Drawing.Point(42, 205);
            this.buttontambah.Name = "buttontambah";
            this.buttontambah.Size = new System.Drawing.Size(90, 51);
            this.buttontambah.TabIndex = 6;
            this.buttontambah.Text = "+";
            this.buttontambah.UseVisualStyleBackColor = false;
            this.buttontambah.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonkurang
            // 
            this.buttonkurang.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonkurang.Location = new System.Drawing.Point(181, 205);
            this.buttonkurang.Name = "buttonkurang";
            this.buttonkurang.Size = new System.Drawing.Size(92, 51);
            this.buttonkurang.TabIndex = 7;
            this.buttonkurang.Text = "-";
            this.buttonkurang.UseVisualStyleBackColor = false;
            this.buttonkurang.Click += new System.EventHandler(this.buttonkurang_Click);
            // 
            // buttonkali
            // 
            this.buttonkali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonkali.Location = new System.Drawing.Point(42, 262);
            this.buttonkali.Name = "buttonkali";
            this.buttonkali.Size = new System.Drawing.Size(90, 47);
            this.buttonkali.TabIndex = 8;
            this.buttonkali.Text = "x";
            this.buttonkali.UseVisualStyleBackColor = false;
            this.buttonkali.Click += new System.EventHandler(this.buttonkali_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Lime;
            this.button4.Location = new System.Drawing.Point(181, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 47);
            this.button4.TabIndex = 9;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(322, 339);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonkali);
            this.Controls.Add(this.buttonkurang);
            this.Controls.Add(this.buttontambah);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Button buttontambah;
        private System.Windows.Forms.Button buttonkurang;
        private System.Windows.Forms.Button buttonkali;
        private System.Windows.Forms.Button button4;
    }
}

