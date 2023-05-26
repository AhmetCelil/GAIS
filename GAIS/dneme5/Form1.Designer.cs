using System;
using System.Windows.Forms;

namespace dneme5
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
            this.ekle_butonu_f = new System.Windows.Forms.Button();
            this.sil_butonu_f = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.isim_textbox_f = new System.Windows.Forms.TextBox();
            this.soyisim_textbox_f = new System.Windows.Forms.TextBox();
            this.telefon_textbox_f = new System.Windows.Forms.TextBox();
            this.ID_textbox_f = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guncelle_button_f = new System.Windows.Forms.Button();
            this.kisiGoruntule_button_f = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tcsorgu_textbox_f = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tckimlik_textbox_f = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ekle_butonu_f
            // 
            this.ekle_butonu_f.Location = new System.Drawing.Point(402, 29);
            this.ekle_butonu_f.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ekle_butonu_f.Name = "ekle_butonu_f";
            this.ekle_butonu_f.Size = new System.Drawing.Size(97, 33);
            this.ekle_butonu_f.TabIndex = 0;
            this.ekle_butonu_f.Text = "Ekle";
            this.ekle_butonu_f.UseVisualStyleBackColor = true;
            this.ekle_butonu_f.Click += new System.EventHandler(this.yaz_butonu_f_Click);
            // 
            // sil_butonu_f
            // 
            this.sil_butonu_f.Location = new System.Drawing.Point(402, 68);
            this.sil_butonu_f.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sil_butonu_f.Name = "sil_butonu_f";
            this.sil_butonu_f.Size = new System.Drawing.Size(97, 33);
            this.sil_butonu_f.TabIndex = 1;
            this.sil_butonu_f.Text = "Sil";
            this.sil_butonu_f.UseVisualStyleBackColor = true;
            this.sil_butonu_f.Click += new System.EventHandler(this.sil_butonu_f_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 220);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(958, 322);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // isim_textbox_f
            // 
            this.isim_textbox_f.Location = new System.Drawing.Point(138, 65);
            this.isim_textbox_f.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.isim_textbox_f.Multiline = true;
            this.isim_textbox_f.Name = "isim_textbox_f";
            this.isim_textbox_f.Size = new System.Drawing.Size(249, 22);
            this.isim_textbox_f.TabIndex = 4;
            this.isim_textbox_f.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // soyisim_textbox_f
            // 
            this.soyisim_textbox_f.Location = new System.Drawing.Point(138, 107);
            this.soyisim_textbox_f.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soyisim_textbox_f.Multiline = true;
            this.soyisim_textbox_f.Name = "soyisim_textbox_f";
            this.soyisim_textbox_f.Size = new System.Drawing.Size(249, 21);
            this.soyisim_textbox_f.TabIndex = 5;
            this.soyisim_textbox_f.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // telefon_textbox_f
            // 
            this.telefon_textbox_f.Location = new System.Drawing.Point(138, 141);
            this.telefon_textbox_f.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telefon_textbox_f.Multiline = true;
            this.telefon_textbox_f.Name = "telefon_textbox_f";
            this.telefon_textbox_f.Size = new System.Drawing.Size(249, 22);
            this.telefon_textbox_f.TabIndex = 6;
            this.telefon_textbox_f.TextChanged += new System.EventHandler(this.telefon_textbox_f_TextChanged);
            // 
            // ID_textbox_f
            // 
            this.ID_textbox_f.Enabled = false;
            this.ID_textbox_f.Location = new System.Drawing.Point(138, 24);
            this.ID_textbox_f.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ID_textbox_f.Multiline = true;
            this.ID_textbox_f.Name = "ID_textbox_f";
            this.ID_textbox_f.Size = new System.Drawing.Size(249, 25);
            this.ID_textbox_f.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(56, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(50, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(50, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Telefon";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(56, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // guncelle_button_f
            // 
            this.guncelle_button_f.Location = new System.Drawing.Point(402, 107);
            this.guncelle_button_f.Margin = new System.Windows.Forms.Padding(4);
            this.guncelle_button_f.Name = "guncelle_button_f";
            this.guncelle_button_f.Size = new System.Drawing.Size(97, 31);
            this.guncelle_button_f.TabIndex = 12;
            this.guncelle_button_f.Text = "güncellle";
            this.guncelle_button_f.UseVisualStyleBackColor = true;
            this.guncelle_button_f.Click += new System.EventHandler(this.guncelle_button_f_Click);
            // 
            // kisiGoruntule_button_f
            // 
            this.kisiGoruntule_button_f.Location = new System.Drawing.Point(856, 161);
            this.kisiGoruntule_button_f.Name = "kisiGoruntule_button_f";
            this.kisiGoruntule_button_f.Size = new System.Drawing.Size(100, 42);
            this.kisiGoruntule_button_f.TabIndex = 13;
            this.kisiGoruntule_button_f.Text = "kişiyi görüntüle";
            this.kisiGoruntule_button_f.UseVisualStyleBackColor = true;
            this.kisiGoruntule_button_f.Click += new System.EventHandler(this.kisiGoruntule_button_f_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\celil\\Desktop\\gazi.PNG";
            this.pictureBox1.Location = new System.Drawing.Point(856, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(556, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "T.C. numarası:";
            // 
            // tcsorgu_textbox_f
            // 
            this.tcsorgu_textbox_f.Location = new System.Drawing.Point(560, 50);
            this.tcsorgu_textbox_f.Name = "tcsorgu_textbox_f";
            this.tcsorgu_textbox_f.Size = new System.Drawing.Size(164, 22);
            this.tcsorgu_textbox_f.TabIndex = 16;
            this.tcsorgu_textbox_f.TextChanged += new System.EventHandler(this.tcsorgu_textbox_f_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "TC kimlik no";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tckimlik_textbox_f
            // 
            this.tckimlik_textbox_f.Location = new System.Drawing.Point(138, 181);
            this.tckimlik_textbox_f.Name = "tckimlik_textbox_f";
            this.tckimlik_textbox_f.Size = new System.Drawing.Size(252, 22);
            this.tckimlik_textbox_f.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.tckimlik_textbox_f);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tcsorgu_textbox_f);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kisiGoruntule_button_f);
            this.Controls.Add(this.guncelle_button_f);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID_textbox_f);
            this.Controls.Add(this.telefon_textbox_f);
            this.Controls.Add(this.soyisim_textbox_f);
            this.Controls.Add(this.isim_textbox_f);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sil_butonu_f);
            this.Controls.Add(this.ekle_butonu_f);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ekle_butonu_f;
        private System.Windows.Forms.Button sil_butonu_f;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox isim_textbox_f;
        private System.Windows.Forms.TextBox soyisim_textbox_f;
        private System.Windows.Forms.TextBox telefon_textbox_f;
        private System.Windows.Forms.TextBox ID_textbox_f;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button guncelle_button_f;
        private Button kisiGoruntule_button_f;
        private PictureBox pictureBox1;
        private Label label5;
        private TextBox tcsorgu_textbox_f;
        private Label label6;
        private TextBox tckimlik_textbox_f;
    }
}

