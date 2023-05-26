namespace dneme5
{
    partial class GAIS
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mailKontrol_textbox_f = new System.Windows.Forms.TextBox();
            this.sifreKontrol_textbox_f = new System.Windows.Forms.TextBox();
            this.giris_button_f = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\celil\\Desktop\\gazi.PNG";
            this.pictureBox1.Location = new System.Drawing.Point(416, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(367, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "e-mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(388, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "sifre:";
            // 
            // mailKontrol_textbox_f
            // 
            this.mailKontrol_textbox_f.Location = new System.Drawing.Point(459, 270);
            this.mailKontrol_textbox_f.Name = "mailKontrol_textbox_f";
            this.mailKontrol_textbox_f.Size = new System.Drawing.Size(195, 22);
            this.mailKontrol_textbox_f.TabIndex = 3;
            this.mailKontrol_textbox_f.TextChanged += new System.EventHandler(this.mailKontrol_textbox_f_TextChanged);
            // 
            // sifreKontrol_textbox_f
            // 
            this.sifreKontrol_textbox_f.Location = new System.Drawing.Point(459, 311);
            this.sifreKontrol_textbox_f.Name = "sifreKontrol_textbox_f";
            this.sifreKontrol_textbox_f.PasswordChar = '*';
            this.sifreKontrol_textbox_f.Size = new System.Drawing.Size(195, 22);
            this.sifreKontrol_textbox_f.TabIndex = 4;
            // 
            // giris_button_f
            // 
            this.giris_button_f.Location = new System.Drawing.Point(459, 357);
            this.giris_button_f.Name = "giris_button_f";
            this.giris_button_f.Size = new System.Drawing.Size(100, 43);
            this.giris_button_f.TabIndex = 5;
            this.giris_button_f.Text = "Giris";
            this.giris_button_f.UseVisualStyleBackColor = true;
            this.giris_button_f.Click += new System.EventHandler(this.giris_button_f_Click);
            // 
            // GAIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.giris_button_f);
            this.Controls.Add(this.sifreKontrol_textbox_f);
            this.Controls.Add(this.mailKontrol_textbox_f);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GAIS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GAIS";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mailKontrol_textbox_f;
        private System.Windows.Forms.TextBox sifreKontrol_textbox_f;
        private System.Windows.Forms.Button giris_button_f;
    }
}