namespace prjHafta12
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKiloWatt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabFaturalar = new System.Windows.Forms.TabControl();
            this.tabElektrik = new System.Windows.Forms.TabPage();
            this.rbCokZamanli = new System.Windows.Forms.RadioButton();
            this.rbTekZamanli = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGece = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPuant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGunduz = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabInternet = new System.Windows.Forms.TabPage();
            this.txtKullanilanGB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKota = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabSu = new System.Windows.Forms.TabPage();
            this.txtKullanilanSuMiktari = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFaturaTutari = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabFaturalar.SuspendLayout();
            this.tabElektrik.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabInternet.SuspendLayout();
            this.tabSu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKiloWatt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(252, 71);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tek Zamanlı";
            // 
            // txtKiloWatt
            // 
            this.txtKiloWatt.Location = new System.Drawing.Point(99, 31);
            this.txtKiloWatt.Margin = new System.Windows.Forms.Padding(4);
            this.txtKiloWatt.Name = "txtKiloWatt";
            this.txtKiloWatt.Size = new System.Drawing.Size(132, 22);
            this.txtKiloWatt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kilo Watt:";
            // 
            // tabFaturalar
            // 
            this.tabFaturalar.Controls.Add(this.tabElektrik);
            this.tabFaturalar.Controls.Add(this.tabInternet);
            this.tabFaturalar.Controls.Add(this.tabSu);
            this.tabFaturalar.Location = new System.Drawing.Point(16, 15);
            this.tabFaturalar.Margin = new System.Windows.Forms.Padding(4);
            this.tabFaturalar.Name = "tabFaturalar";
            this.tabFaturalar.SelectedIndex = 0;
            this.tabFaturalar.Size = new System.Drawing.Size(612, 182);
            this.tabFaturalar.TabIndex = 2;
            // 
            // tabElektrik
            // 
            this.tabElektrik.Controls.Add(this.rbCokZamanli);
            this.tabElektrik.Controls.Add(this.rbTekZamanli);
            this.tabElektrik.Controls.Add(this.groupBox2);
            this.tabElektrik.Controls.Add(this.groupBox1);
            this.tabElektrik.Location = new System.Drawing.Point(4, 25);
            this.tabElektrik.Margin = new System.Windows.Forms.Padding(4);
            this.tabElektrik.Name = "tabElektrik";
            this.tabElektrik.Padding = new System.Windows.Forms.Padding(4);
            this.tabElektrik.Size = new System.Drawing.Size(604, 153);
            this.tabElektrik.TabIndex = 0;
            this.tabElektrik.Text = "Elektrik";
            this.tabElektrik.UseVisualStyleBackColor = true;
            // 
            // rbCokZamanli
            // 
            this.rbCokZamanli.AutoSize = true;
            this.rbCokZamanli.Location = new System.Drawing.Point(304, 42);
            this.rbCokZamanli.Margin = new System.Windows.Forms.Padding(4);
            this.rbCokZamanli.Name = "rbCokZamanli";
            this.rbCokZamanli.Size = new System.Drawing.Size(17, 16);
            this.rbCokZamanli.TabIndex = 4;
            this.rbCokZamanli.TabStop = true;
            this.rbCokZamanli.UseVisualStyleBackColor = true;
            // 
            // rbTekZamanli
            // 
            this.rbTekZamanli.AutoSize = true;
            this.rbTekZamanli.Location = new System.Drawing.Point(8, 42);
            this.rbTekZamanli.Margin = new System.Windows.Forms.Padding(4);
            this.rbTekZamanli.Name = "rbTekZamanli";
            this.rbTekZamanli.Size = new System.Drawing.Size(17, 16);
            this.rbTekZamanli.TabIndex = 3;
            this.rbTekZamanli.TabStop = true;
            this.rbTekZamanli.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGece);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPuant);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtGunduz);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(331, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(252, 133);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Çok Zamanlı";
            // 
            // txtGece
            // 
            this.txtGece.Location = new System.Drawing.Point(99, 94);
            this.txtGece.Margin = new System.Windows.Forms.Padding(4);
            this.txtGece.Name = "txtGece";
            this.txtGece.Size = new System.Drawing.Size(132, 22);
            this.txtGece.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gece:";
            // 
            // txtPuant
            // 
            this.txtPuant.Location = new System.Drawing.Point(99, 62);
            this.txtPuant.Margin = new System.Windows.Forms.Padding(4);
            this.txtPuant.Name = "txtPuant";
            this.txtPuant.Size = new System.Drawing.Size(132, 22);
            this.txtPuant.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Puant:";
            // 
            // txtGunduz
            // 
            this.txtGunduz.Location = new System.Drawing.Point(99, 31);
            this.txtGunduz.Margin = new System.Windows.Forms.Padding(4);
            this.txtGunduz.Name = "txtGunduz";
            this.txtGunduz.Size = new System.Drawing.Size(132, 22);
            this.txtGunduz.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gündüz:";
            // 
            // tabInternet
            // 
            this.tabInternet.Controls.Add(this.txtKullanilanGB);
            this.tabInternet.Controls.Add(this.label6);
            this.tabInternet.Controls.Add(this.txtKota);
            this.tabInternet.Controls.Add(this.label7);
            this.tabInternet.Location = new System.Drawing.Point(4, 25);
            this.tabInternet.Margin = new System.Windows.Forms.Padding(4);
            this.tabInternet.Name = "tabInternet";
            this.tabInternet.Padding = new System.Windows.Forms.Padding(4);
            this.tabInternet.Size = new System.Drawing.Size(604, 153);
            this.tabInternet.TabIndex = 1;
            this.tabInternet.Text = "İnternet";
            this.tabInternet.UseVisualStyleBackColor = true;
            // 
            // txtKullanilanGB
            // 
            this.txtKullanilanGB.Location = new System.Drawing.Point(337, 10);
            this.txtKullanilanGB.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullanilanGB.Name = "txtKullanilanGB";
            this.txtKullanilanGB.Size = new System.Drawing.Size(132, 22);
            this.txtKullanilanGB.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Kullanılan GB:";
            // 
            // txtKota
            // 
            this.txtKota.Location = new System.Drawing.Point(68, 10);
            this.txtKota.Margin = new System.Windows.Forms.Padding(4);
            this.txtKota.Name = "txtKota";
            this.txtKota.Size = new System.Drawing.Size(132, 22);
            this.txtKota.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Kota :";
            // 
            // tabSu
            // 
            this.tabSu.Controls.Add(this.txtKullanilanSuMiktari);
            this.tabSu.Controls.Add(this.label8);
            this.tabSu.Location = new System.Drawing.Point(4, 25);
            this.tabSu.Margin = new System.Windows.Forms.Padding(4);
            this.tabSu.Name = "tabSu";
            this.tabSu.Padding = new System.Windows.Forms.Padding(4);
            this.tabSu.Size = new System.Drawing.Size(604, 153);
            this.tabSu.TabIndex = 2;
            this.tabSu.Text = "Su";
            this.tabSu.UseVisualStyleBackColor = true;
            // 
            // txtKullanilanSuMiktari
            // 
            this.txtKullanilanSuMiktari.Location = new System.Drawing.Point(171, 10);
            this.txtKullanilanSuMiktari.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullanilanSuMiktari.Name = "txtKullanilanSuMiktari";
            this.txtKullanilanSuMiktari.Size = new System.Drawing.Size(132, 22);
            this.txtKullanilanSuMiktari.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Kullanılan Su Miktarı :";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(53, 204);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(4);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 28);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fatura Tutarı:";
            // 
            // lblFaturaTutari
            // 
            this.lblFaturaTutari.AutoSize = true;
            this.lblFaturaTutari.Location = new System.Drawing.Point(312, 210);
            this.lblFaturaTutari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFaturaTutari.Name = "lblFaturaTutari";
            this.lblFaturaTutari.Size = new System.Drawing.Size(16, 17);
            this.lblFaturaTutari.TabIndex = 6;
            this.lblFaturaTutari.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 302);
            this.Controls.Add(this.lblFaturaTutari);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.tabFaturalar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Fatura Hesaplama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabFaturalar.ResumeLayout(false);
            this.tabElektrik.ResumeLayout(false);
            this.tabElektrik.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabInternet.ResumeLayout(false);
            this.tabInternet.PerformLayout();
            this.tabSu.ResumeLayout(false);
            this.tabSu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabFaturalar;
        private System.Windows.Forms.TabPage tabElektrik;
        private System.Windows.Forms.TabPage tabSu;
        private System.Windows.Forms.TextBox txtKiloWatt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbCokZamanli;
        private System.Windows.Forms.RadioButton rbTekZamanli;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGunduz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGece;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPuant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKullanilanGB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKota;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKullanilanSuMiktari;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFaturaTutari;
        private System.Windows.Forms.TabPage tabInternet;
    }
}

