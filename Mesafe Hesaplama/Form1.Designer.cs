
namespace Mesafe_Hesaplama
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
            this.textBox1Mesafe = new System.Windows.Forms.TextBox();
            this.textBox2Hiz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4Saatyaz = new System.Windows.Forms.Label();
            this.button1Hesaplama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1Mesafe
            // 
            this.textBox1Mesafe.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1Mesafe.Location = new System.Drawing.Point(158, 14);
            this.textBox1Mesafe.Name = "textBox1Mesafe";
            this.textBox1Mesafe.Size = new System.Drawing.Size(143, 25);
            this.textBox1Mesafe.TabIndex = 0;
            // 
            // textBox2Hiz
            // 
            this.textBox2Hiz.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2Hiz.Location = new System.Drawing.Point(158, 75);
            this.textBox2Hiz.Name = "textBox2Hiz";
            this.textBox2Hiz.Size = new System.Drawing.Size(143, 25);
            this.textBox2Hiz.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(52, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mesafe Gir :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(73, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hızı Gir :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Varılacak Saat :";
            // 
            // label4Saatyaz
            // 
            this.label4Saatyaz.AutoSize = true;
            this.label4Saatyaz.BackColor = System.Drawing.Color.Coral;
            this.label4Saatyaz.Font = new System.Drawing.Font("Georgia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4Saatyaz.ForeColor = System.Drawing.Color.Blue;
            this.label4Saatyaz.Location = new System.Drawing.Point(171, 188);
            this.label4Saatyaz.Name = "label4Saatyaz";
            this.label4Saatyaz.Size = new System.Drawing.Size(42, 25);
            this.label4Saatyaz.TabIndex = 5;
            this.label4Saatyaz.Text = "00";
            // 
            // button1Hesaplama
            // 
            this.button1Hesaplama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1Hesaplama.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1Hesaplama.Location = new System.Drawing.Point(158, 115);
            this.button1Hesaplama.Name = "button1Hesaplama";
            this.button1Hesaplama.Size = new System.Drawing.Size(143, 39);
            this.button1Hesaplama.TabIndex = 6;
            this.button1Hesaplama.Text = "Hesapla ";
            this.button1Hesaplama.UseVisualStyleBackColor = true;
            this.button1Hesaplama.Click += new System.EventHandler(this.button1Hesaplama_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1Hesaplama;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(441, 241);
            this.Controls.Add(this.button1Hesaplama);
            this.Controls.Add(this.label4Saatyaz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2Hiz);
            this.Controls.Add(this.textBox1Mesafe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mesafe Hesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1Mesafe;
        private System.Windows.Forms.TextBox textBox2Hiz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4Saatyaz;
        private System.Windows.Forms.Button button1Hesaplama;
    }
}

