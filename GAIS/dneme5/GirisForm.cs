using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace dneme5
{
    public partial class GAIS : Form
    {
        public GAIS()
        {
            InitializeComponent();
        }

        private void mailKontrol_textbox_f_TextChanged(object sender, EventArgs e)
        {

        }

        private void giris_button_f_Click(object sender, EventArgs e)
        {
            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source= dbKisiler.accdb");
            connect.Open();
            OleDbCommand command = new OleDbCommand("SELECT *from akademisyenler where mail=@mail and sifre=@sifre", connect);
           
            command.Parameters.Add("mail", mailKontrol_textbox_f.Text);
            command.Parameters.Add("sifre", sifreKontrol_textbox_f.Text);
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                Form1 ac = new Form1();
                ac.Show();
                this.Hide();
            }
            else MessageBox.Show("sifre veya mail yanlis!!");
        }
    }
}
