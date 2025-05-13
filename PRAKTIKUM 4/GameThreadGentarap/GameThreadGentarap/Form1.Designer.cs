namespace GameThreadGentarap
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
            this.components = new System.ComponentModel.Container();
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbP1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbP2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbP3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btP3 = new System.Windows.Forms.Button();
            this.btP2 = new System.Windows.Forms.Button();
            this.btP1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Start.Location = new System.Drawing.Point(61, 417);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(124, 54);
            this.Start.TabIndex = 3;
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player 1 :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbP1
            // 
            this.lbP1.AutoSize = true;
            this.lbP1.Location = new System.Drawing.Point(453, 438);
            this.lbP1.Name = "lbP1";
            this.lbP1.Size = new System.Drawing.Size(14, 16);
            this.lbP1.TabIndex = 5;
            this.lbP1.Text = "0";
            this.lbP1.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(601, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Player 2 :";
            // 
            // lbP2
            // 
            this.lbP2.AutoSize = true;
            this.lbP2.Location = new System.Drawing.Point(669, 438);
            this.lbP2.Name = "lbP2";
            this.lbP2.Size = new System.Drawing.Size(14, 16);
            this.lbP2.TabIndex = 7;
            this.lbP2.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(869, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Player 3 :";
            // 
            // lbP3
            // 
            this.lbP3.AutoSize = true;
            this.lbP3.Location = new System.Drawing.Point(937, 438);
            this.lbP3.Name = "lbP3";
            this.lbP3.Size = new System.Drawing.Size(14, 16);
            this.lbP3.TabIndex = 9;
            this.lbP3.Text = "0";
            this.lbP3.Click += new System.EventHandler(this.label6_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btP3
            // 
            this.btP3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btP3.Location = new System.Drawing.Point(49, 270);
            this.btP3.Name = "btP3";
            this.btP3.Size = new System.Drawing.Size(241, 94);
            this.btP3.TabIndex = 2;
            this.btP3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btP3.UseVisualStyleBackColor = true;
            // 
            // btP2
            // 
            this.btP2.BackColor = System.Drawing.SystemColors.Control;
            this.btP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btP2.Location = new System.Drawing.Point(49, 166);
            this.btP2.Name = "btP2";
            this.btP2.Size = new System.Drawing.Size(241, 82);
            this.btP2.TabIndex = 1;
            this.btP2.UseVisualStyleBackColor = false;
            // 
            // btP1
            // 
            this.btP1.BackColor = System.Drawing.Color.Transparent;
            this.btP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btP1.ForeColor = System.Drawing.Color.Transparent;
            this.btP1.Location = new System.Drawing.Point(49, 61);
            this.btP1.Name = "btP1";
            this.btP1.Size = new System.Drawing.Size(241, 99);
            this.btP1.TabIndex = 0;
            this.btP1.Text = "\r\n";
            this.btP1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(972, 522);
            this.Controls.Add(this.lbP3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbP2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbP1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.btP3);
            this.Controls.Add(this.btP2);
            this.Controls.Add(this.btP1);
            this.Name = "Form1";
            this.Text = "Game Racing With Thread";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btP1;
        private System.Windows.Forms.Button btP2;
        private System.Windows.Forms.Button btP3;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbP1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbP2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbP3;
        private System.Windows.Forms.Timer timer1;
    }
}

