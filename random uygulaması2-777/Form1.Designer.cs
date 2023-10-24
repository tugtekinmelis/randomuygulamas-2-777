namespace random_uygulaması2_777
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
            this.lbNotlar = new System.Windows.Forms.ListBox();
            this.btnUret = new System.Windows.Forms.Button();
            this.lblKalan = new System.Windows.Forms.Label();
            this.lblDuz = new System.Windows.Forms.Label();
            this.lblTakdir = new System.Windows.Forms.Label();
            this.lblTesekkur = new System.Windows.Forms.Label();
            this.btnDurum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ögrenci notları:";
            // 
            // lbNotlar
            // 
            this.lbNotlar.FormattingEnabled = true;
            this.lbNotlar.Location = new System.Drawing.Point(12, 62);
            this.lbNotlar.Name = "lbNotlar";
            this.lbNotlar.Size = new System.Drawing.Size(173, 355);
            this.lbNotlar.TabIndex = 1;
            // 
            // btnUret
            // 
            this.btnUret.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUret.Location = new System.Drawing.Point(207, 62);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(131, 41);
            this.btnUret.TabIndex = 2;
            this.btnUret.Text = "üret";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // lblKalan
            // 
            this.lblKalan.AutoSize = true;
            this.lblKalan.Location = new System.Drawing.Point(383, 204);
            this.lblKalan.Name = "lblKalan";
            this.lblKalan.Size = new System.Drawing.Size(102, 13);
            this.lblKalan.TabIndex = 3;
            this.lblKalan.Text = "kalan öğrenci sayısı:";
            // 
            // lblDuz
            // 
            this.lblDuz.AutoSize = true;
            this.lblDuz.Location = new System.Drawing.Point(383, 236);
            this.lblDuz.Name = "lblDuz";
            this.lblDuz.Size = new System.Drawing.Size(88, 13);
            this.lblDuz.TabIndex = 4;
            this.lblDuz.Text = "düz geçen sayısı:";
            // 
            // lblTakdir
            // 
            this.lblTakdir.AutoSize = true;
            this.lblTakdir.Location = new System.Drawing.Point(384, 295);
            this.lblTakdir.Name = "lblTakdir";
            this.lblTakdir.Size = new System.Drawing.Size(64, 13);
            this.lblTakdir.TabIndex = 5;
            this.lblTakdir.Text = "takdir sayısı:";
            // 
            // lblTesekkur
            // 
            this.lblTesekkur.AutoSize = true;
            this.lblTesekkur.Location = new System.Drawing.Point(383, 267);
            this.lblTesekkur.Name = "lblTesekkur";
            this.lblTesekkur.Size = new System.Drawing.Size(82, 13);
            this.lblTesekkur.TabIndex = 6;
            this.lblTesekkur.Text = " teşekkür sayısı:";
            // 
            // btnDurum
            // 
            this.btnDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDurum.Location = new System.Drawing.Point(207, 204);
            this.btnDurum.Name = "btnDurum";
            this.btnDurum.Size = new System.Drawing.Size(131, 54);
            this.btnDurum.TabIndex = 7;
            this.btnDurum.Text = "geçme/kalma durumu";
            this.btnDurum.UseVisualStyleBackColor = true;
            this.btnDurum.Click += new System.EventHandler(this.btnDurum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDurum);
            this.Controls.Add(this.lblTesekkur);
            this.Controls.Add(this.lblTakdir);
            this.Controls.Add(this.lblDuz);
            this.Controls.Add(this.lblKalan);
            this.Controls.Add(this.btnUret);
            this.Controls.Add(this.lbNotlar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbNotlar;
        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.Label lblKalan;
        private System.Windows.Forms.Label lblDuz;
        private System.Windows.Forms.Label lblTakdir;
        private System.Windows.Forms.Label lblTesekkur;
        private System.Windows.Forms.Button btnDurum;
    }
}

