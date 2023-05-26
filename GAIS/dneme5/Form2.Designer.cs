namespace dneme5
{
    partial class Form2
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ID_textbox_f2 = new System.Windows.Forms.TextBox();
            this.ekle_button_f2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ders_textbox_f2 = new System.Windows.Forms.TextBox();
            this.not_textbox_f2 = new System.Windows.Forms.TextBox();
            this.harfNotu_textbox_f2 = new System.Windows.Forms.TextBox();
            this.akts_textbox_f2 = new System.Windows.Forms.TextBox();
            this.sil_button_f2 = new System.Windows.Forms.Button();
            this.güncelle_button_f2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.akademisyen_textbox_f2 = new System.Windows.Forms.TextBox();
            this.pictureGazi = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.agnohesapla_textbox_f2 = new System.Windows.Forms.TextBox();
            this.agnohesapla_button_f = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGazi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 219);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(958, 322);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // ID_textbox_f2
            // 
            this.ID_textbox_f2.Enabled = false;
            this.ID_textbox_f2.Location = new System.Drawing.Point(145, 32);
            this.ID_textbox_f2.Name = "ID_textbox_f2";
            this.ID_textbox_f2.ReadOnly = true;
            this.ID_textbox_f2.Size = new System.Drawing.Size(198, 22);
            this.ID_textbox_f2.TabIndex = 1;
            this.ID_textbox_f2.TextChanged += new System.EventHandler(this.ID_textbox_f2_TextChanged);
            // 
            // ekle_button_f2
            // 
            this.ekle_button_f2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ekle_button_f2.Location = new System.Drawing.Point(374, 32);
            this.ekle_button_f2.Name = "ekle_button_f2";
            this.ekle_button_f2.Size = new System.Drawing.Size(96, 42);
            this.ekle_button_f2.TabIndex = 2;
            this.ekle_button_f2.Text = "ekle";
            this.ekle_button_f2.UseVisualStyleBackColor = true;
            this.ekle_button_f2.Click += new System.EventHandler(this.veriFoster_textbox_f2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ders";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Not";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Harf notu";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Akts";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ders_textbox_f2
            // 
            this.ders_textbox_f2.Location = new System.Drawing.Point(145, 62);
            this.ders_textbox_f2.Name = "ders_textbox_f2";
            this.ders_textbox_f2.Size = new System.Drawing.Size(198, 22);
            this.ders_textbox_f2.TabIndex = 9;
            this.ders_textbox_f2.TextChanged += new System.EventHandler(this.ders_textbox_f2_TextChanged);
            // 
            // not_textbox_f2
            // 
            this.not_textbox_f2.Location = new System.Drawing.Point(145, 91);
            this.not_textbox_f2.Name = "not_textbox_f2";
            this.not_textbox_f2.Size = new System.Drawing.Size(198, 22);
            this.not_textbox_f2.TabIndex = 10;
            // 
            // harfNotu_textbox_f2
            // 
            this.harfNotu_textbox_f2.Location = new System.Drawing.Point(145, 120);
            this.harfNotu_textbox_f2.Name = "harfNotu_textbox_f2";
            this.harfNotu_textbox_f2.Size = new System.Drawing.Size(198, 22);
            this.harfNotu_textbox_f2.TabIndex = 11;
            // 
            // akts_textbox_f2
            // 
            this.akts_textbox_f2.Location = new System.Drawing.Point(145, 149);
            this.akts_textbox_f2.Name = "akts_textbox_f2";
            this.akts_textbox_f2.Size = new System.Drawing.Size(198, 22);
            this.akts_textbox_f2.TabIndex = 12;
            // 
            // sil_button_f2
            // 
            this.sil_button_f2.Location = new System.Drawing.Point(374, 81);
            this.sil_button_f2.Name = "sil_button_f2";
            this.sil_button_f2.Size = new System.Drawing.Size(96, 42);
            this.sil_button_f2.TabIndex = 13;
            this.sil_button_f2.Text = "sil";
            this.sil_button_f2.UseVisualStyleBackColor = true;
            this.sil_button_f2.Click += new System.EventHandler(this.sil_button_f2_Click);
            // 
            // güncelle_button_f2
            // 
            this.güncelle_button_f2.Location = new System.Drawing.Point(374, 130);
            this.güncelle_button_f2.Name = "güncelle_button_f2";
            this.güncelle_button_f2.Size = new System.Drawing.Size(96, 41);
            this.güncelle_button_f2.TabIndex = 14;
            this.güncelle_button_f2.Text = "güncelle";
            this.güncelle_button_f2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Akademisyen";
            // 
            // akademisyen_textbox_f2
            // 
            this.akademisyen_textbox_f2.Location = new System.Drawing.Point(145, 178);
            this.akademisyen_textbox_f2.Name = "akademisyen_textbox_f2";
            this.akademisyen_textbox_f2.Size = new System.Drawing.Size(198, 22);
            this.akademisyen_textbox_f2.TabIndex = 16;
            // 
            // pictureGazi
            // 
            this.pictureGazi.ImageLocation = "C:\\Users\\celil\\Desktop\\gazi.PNG";
            this.pictureGazi.Location = new System.Drawing.Point(870, 12);
            this.pictureGazi.Name = "pictureGazi";
            this.pictureGazi.Size = new System.Drawing.Size(100, 100);
            this.pictureGazi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureGazi.TabIndex = 17;
            this.pictureGazi.TabStop = false;
            this.pictureGazi.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(546, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 26);
            this.label7.TabIndex = 18;
            this.label7.Text = "agno hesapla";
            // 
            // agnohesapla_textbox_f2
            // 
            this.agnohesapla_textbox_f2.Location = new System.Drawing.Point(693, 91);
            this.agnohesapla_textbox_f2.Multiline = true;
            this.agnohesapla_textbox_f2.Name = "agnohesapla_textbox_f2";
            this.agnohesapla_textbox_f2.Size = new System.Drawing.Size(96, 35);
            this.agnohesapla_textbox_f2.TabIndex = 19;
            this.agnohesapla_textbox_f2.TextChanged += new System.EventHandler(this.agnohesapla_textbox_f2_TextChanged);
            // 
            // agnohesapla_button_f
            // 
            this.agnohesapla_button_f.Location = new System.Drawing.Point(693, 40);
            this.agnohesapla_button_f.Name = "agnohesapla_button_f";
            this.agnohesapla_button_f.Size = new System.Drawing.Size(96, 42);
            this.agnohesapla_button_f.TabIndex = 20;
            this.agnohesapla_button_f.Text = "hesapla";
            this.agnohesapla_button_f.UseVisualStyleBackColor = true;
            this.agnohesapla_button_f.Click += new System.EventHandler(this.agnohesapla_button_f_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.agnohesapla_button_f);
            this.Controls.Add(this.agnohesapla_textbox_f2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureGazi);
            this.Controls.Add(this.akademisyen_textbox_f2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.güncelle_button_f2);
            this.Controls.Add(this.sil_button_f2);
            this.Controls.Add(this.akts_textbox_f2);
            this.Controls.Add(this.harfNotu_textbox_f2);
            this.Controls.Add(this.not_textbox_f2);
            this.Controls.Add(this.ders_textbox_f2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ekle_button_f2);
            this.Controls.Add(this.ID_textbox_f2);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGazi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox ID_textbox_f2;
        private System.Windows.Forms.Button ekle_button_f2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox ders_textbox_f2;
        private System.Windows.Forms.TextBox not_textbox_f2;
        private System.Windows.Forms.TextBox harfNotu_textbox_f2;
        private System.Windows.Forms.TextBox akts_textbox_f2;
        private System.Windows.Forms.Button sil_button_f2;
        private System.Windows.Forms.Button güncelle_button_f2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox akademisyen_textbox_f2;
        private System.Windows.Forms.PictureBox pictureGazi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox agnohesapla_textbox_f2;
        private System.Windows.Forms.Button agnohesapla_button_f;
    }
}