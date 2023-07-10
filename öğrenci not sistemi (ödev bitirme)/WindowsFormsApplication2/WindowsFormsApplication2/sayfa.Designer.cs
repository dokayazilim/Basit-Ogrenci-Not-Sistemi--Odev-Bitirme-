namespace WindowsFormsApplication2
{
    partial class sayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sayfa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.hesapla = new System.Windows.Forms.Button();
            this.rkal = new System.Windows.Forms.RadioButton();
            this.rgec = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.y3 = new System.Windows.Forms.TextBox();
            this.y2 = new System.Windows.Forms.TextBox();
            this.y1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sonuc1 = new System.Windows.Forms.Label();
            this.s2 = new System.Windows.Forms.Label();
            this.s1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.hesapla);
            this.groupBox1.Controls.Add(this.rkal);
            this.groupBox1.Controls.Add(this.rgec);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.y3);
            this.groupBox1.Controls.Add(this.y2);
            this.groupBox1.Controls.Add(this.y1);
            this.groupBox1.Location = new System.Drawing.Point(79, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrencinin Yazılı Notları";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(265, 187);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(134, 23);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // hesapla
            // 
            this.hesapla.Location = new System.Drawing.Point(127, 187);
            this.hesapla.Name = "hesapla";
            this.hesapla.Size = new System.Drawing.Size(132, 23);
            this.hesapla.TabIndex = 3;
            this.hesapla.Text = "Hesapla";
            this.hesapla.UseVisualStyleBackColor = true;
            this.hesapla.Click += new System.EventHandler(this.hesapla_Click);
            // 
            // rkal
            // 
            this.rkal.AutoSize = true;
            this.rkal.Location = new System.Drawing.Point(327, 89);
            this.rkal.Name = "rkal";
            this.rkal.Size = new System.Drawing.Size(53, 17);
            this.rkal.TabIndex = 2;
            this.rkal.TabStop = true;
            this.rkal.Text = "Kalsın";
            this.rkal.UseVisualStyleBackColor = true;
            // 
            // rgec
            // 
            this.rgec.AutoSize = true;
            this.rgec.Location = new System.Drawing.Point(327, 41);
            this.rgec.Name = "rgec";
            this.rgec.Size = new System.Drawing.Size(58, 17);
            this.rgec.TabIndex = 2;
            this.rgec.TabStop = true;
            this.rgec.Text = "Geçsin";
            this.rgec.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "3. Yazılı";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. Yazılı";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Yazılı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // y3
            // 
            this.y3.Location = new System.Drawing.Point(132, 145);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(100, 20);
            this.y3.TabIndex = 2;
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(132, 90);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(100, 20);
            this.y2.TabIndex = 1;
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(132, 39);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(100, 20);
            this.y1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.sonuc1);
            this.groupBox2.Controls.Add(this.s2);
            this.groupBox2.Controls.Add(this.s1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(586, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 229);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Tahmini Notu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Öğrencinin Ortalaması";
            // 
            // sonuc1
            // 
            this.sonuc1.AutoSize = true;
            this.sonuc1.Location = new System.Drawing.Point(116, 187);
            this.sonuc1.Name = "sonuc1";
            this.sonuc1.Size = new System.Drawing.Size(38, 13);
            this.sonuc1.TabIndex = 3;
            this.sonuc1.Text = "Sonuç";
            // 
            // s2
            // 
            this.s2.AutoSize = true;
            this.s2.Location = new System.Drawing.Point(155, 123);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(24, 13);
            this.s2.TabIndex = 2;
            this.s2.Text = "Not";
            // 
            // s1
            // 
            this.s1.AutoSize = true;
            this.s1.Location = new System.Drawing.Point(155, 59);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(24, 13);
            this.s1.TabIndex = 2;
            this.s1.Text = "Not";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "2. Tahmini Sözlü Notu :";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "1. Tahmini Sözlü Notu :";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // sayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 294);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sayfa";
            this.Text = "Öğrenci Not Sistemi";
            this.Load += new System.EventHandler(this.sayfa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox y2;
        private System.Windows.Forms.TextBox y1;
        private System.Windows.Forms.RadioButton rkal;
        private System.Windows.Forms.RadioButton rgec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox y3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button hesapla;
        private System.Windows.Forms.Label s1;
        private System.Windows.Forms.Label s2;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label sonuc1;
        private System.Windows.Forms.Label label6;
    }
}