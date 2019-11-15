namespace Vektorel.Windows.ButonPuanApp
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
            this.btnKayit = new System.Windows.Forms.Button();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(233, 231);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(118, 29);
            this.btnKayit.TabIndex = 0;
            this.btnKayit.Text = "Kaydet";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(128, 113);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(46, 17);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Adınız";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(128, 168);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(69, 17);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "Soyadınız";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(233, 108);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(118, 22);
            this.txtad.TabIndex = 3;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(233, 163);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(118, 22);
            this.txtsoyad.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 494);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.btnKayit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        public System.Windows.Forms.TextBox txtad;
        public System.Windows.Forms.TextBox txtsoyad;
    }
}

