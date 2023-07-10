namespace WindowsFormsApplication2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textpw1 = new System.Windows.Forms.TextBox();
            this.textpw2 = new System.Windows.Forms.TextBox();
            this.textpw3 = new System.Windows.Forms.TextBox();
            this.textpw4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textpw1
            // 
            this.textpw1.Location = new System.Drawing.Point(53, 106);
            this.textpw1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textpw1.Name = "textpw1";
            this.textpw1.Size = new System.Drawing.Size(132, 22);
            this.textpw1.TabIndex = 0;
            // 
            // textpw2
            // 
            this.textpw2.Location = new System.Drawing.Point(195, 106);
            this.textpw2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textpw2.Name = "textpw2";
            this.textpw2.Size = new System.Drawing.Size(132, 22);
            this.textpw2.TabIndex = 1;
            // 
            // textpw3
            // 
            this.textpw3.Location = new System.Drawing.Point(335, 106);
            this.textpw3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textpw3.Name = "textpw3";
            this.textpw3.Size = new System.Drawing.Size(132, 22);
            this.textpw3.TabIndex = 2;
            this.textpw3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textpw4
            // 
            this.textpw4.Location = new System.Drawing.Point(475, 106);
            this.textpw4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textpw4.Name = "textpw4";
            this.textpw4.Size = new System.Drawing.Size(132, 22);
            this.textpw4.TabIndex = 3;
            this.textpw4.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lütfen Size Verilen 12 Haneli Aktivasyon Kodunu Giriniz (1111-1111-1111-1111)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 191);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "İleri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(504, 191);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Vazgeç";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 268);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textpw4);
            this.Controls.Add(this.textpw3);
            this.Controls.Add(this.textpw2);
            this.Controls.Add(this.textpw1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Lisans Anahtarı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textpw1;
        private System.Windows.Forms.TextBox textpw2;
        private System.Windows.Forms.TextBox textpw3;
        private System.Windows.Forms.TextBox textpw4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

