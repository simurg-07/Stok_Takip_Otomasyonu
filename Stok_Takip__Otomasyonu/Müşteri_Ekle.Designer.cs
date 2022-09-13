
namespace Stok_Takip__Otomasyonu
{
    partial class Müşteri_Ekle
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
            this.txttc = new System.Windows.Forms.TextBox();
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.txttelefon = new System.Windows.Forms.TextBox();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(200, 45);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(136, 22);
            this.txttc.TabIndex = 0;
            this.txttc.UseWaitCursor = true;
            this.txttc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttc_KeyPress);
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Location = new System.Drawing.Point(200, 83);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(136, 22);
            this.txtadsoyad.TabIndex = 0;
            this.txtadsoyad.UseWaitCursor = true;
            // 
            // txttelefon
            // 
            this.txttelefon.Location = new System.Drawing.Point(200, 121);
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(136, 22);
            this.txttelefon.TabIndex = 0;
            this.txttelefon.UseWaitCursor = true;
            // 
            // txtadres
            // 
            this.txtadres.Location = new System.Drawing.Point(200, 162);
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(136, 22);
            this.txtadres.TabIndex = 0;
            this.txtadres.UseWaitCursor = true;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(200, 200);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(136, 22);
            this.txtemail.TabIndex = 0;
            this.txtemail.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefon";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Adres";
            this.label3.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "E-mail";
            this.label4.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ad Soyad";
            this.label5.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            // 
            // Müşteri_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(439, 330);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.txttelefon);
            this.Controls.Add(this.txtadsoyad);
            this.Controls.Add(this.txttc);
            this.Name = "Müşteri_Ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri_Ekle";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.TextBox txttelefon;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}