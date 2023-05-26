using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dneme5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source= dbKisiler.accdb");
        OleDbCommand komut;
        OleDbDataAdapter data;
        private string akts;
        private string harfNotu;
        static string a;
        //private string veri;
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) // veritabanında bulunan bir satıra tıklandığında datagrid de ilgili verileri gösterir 
        {
            ID_textbox_f2.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            ders_textbox_f2.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            not_textbox_f2.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            harfNotu_textbox_f2.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            akts_textbox_f2.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            akademisyen_textbox_f2.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();

        }
        private void kisileriListele2(string veri) // kisi verilerinin bulunduğu kayıt/okuma yapıldığı formda bulunan id verisini alarak verileri yazdırır
        {

            baglanti2.Open();

            string sorgu = "SELECT * FROM kisiBilgileri WHERE ID = @id";  //kisiBilgileri tablunda id sorgu yapılıyor  
            komut = new OleDbCommand(sorgu, baglanti2);
            komut.Parameters.AddWithValue("@id", veri); 
            data = new OleDbDataAdapter(komut);
            DataTable tablo = new DataTable();
            data.Fill(tablo);        // veirler gösteriliyor
            dataGridView2.DataSource = tablo; 

            baglanti2.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //_kisileriListele2();
        }

        private void ID_textbox_f2_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void veriyiGoster(string veri) // formlar arası ıd verisini aktarmak için public yapılmmıştır.
        {
            ID_textbox_f2.Text = veri;
            kisileriListele2(veri); // formlar arası alınan veri listelemek için parametre olarak gönderiliyor
        }
        

        public void veriFoster_textbox_f2_Click(object sender, EventArgs e)  //ekleme içini yapan 
        {
            string sorgu2 = "INSERT INTO kisiBilgileri (ID,ders,notDegeri,harfnotu,akts,akademisyenmail) values (@id,@ders,@notValue,@harfnot,@akts,@akademisyen);";
            OleDbCommand komut2 = new OleDbCommand(sorgu2, baglanti2);
            // ID
            komut2.Parameters.AddWithValue("@id" , Convert.ToInt32(ID_textbox_f2.Text.ToString()));
            komut2.Parameters.AddWithValue("@ders", ders_textbox_f2.Text);
            komut2.Parameters.AddWithValue("@notValue", not_textbox_f2.Text);
            komut2.Parameters.AddWithValue("@harfnot", harfNotu_textbox_f2.Text);
            komut2.Parameters.AddWithValue("@akts", akts_textbox_f2.Text);
            komut2.Parameters.AddWithValue("@akademisyen", akademisyen_textbox_f2.Text);

            baglanti2.Open();

            komut2.ExecuteNonQuery();

            baglanti2.Close();


            kisileriListele2(ID_textbox_f2.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ders_textbox_f2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       private void agnohesapla_button_f_Click(object sender, EventArgs e) //agno hesaplama
        {

            float notToplam = 0.0f;
            float krediToplam = 0.0f;

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (dataGridView2.CurrentRow.Cells[3].Value.ToString() != null)
                {
                    float not = harfNotuHesapla(dataGridView2.CurrentRow.Cells[3].Value.ToString());
                    float kredi = float.Parse(dataGridView2.CurrentRow.Cells[4].Value.ToString());
                    notToplam += not * kredi;
                    krediToplam += kredi;
                }

            }

            float agno = notToplam / krediToplam;

            agnohesapla_textbox_f2.Text = agno.ToString();

            /*
            harfNotu = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            akts = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            harfNotuHesapla(harfNotu);*/
        }
        
        private float harfNotuHesapla(string harfNotu)
        {
            switch (harfNotu)
            {
                case "AA":
                    return 4.0f;
                case "BA":
                    return 3.5f;
                case "BB":
                    return 3.0f;
                case "CB":
                    return 2.5f;
                case "CC":
                    return 2.0f;
                case "DC":
                    return 1.5f;
                case "DD":
                    return 1.0f;
                case "FF":
                    return 0.0f;
                default:
                    return 0.0f;
            }
        }

        private void agnoHesapla()
        {
            
        }

        private void agnohesapla_textbox_f2_TextChanged(object sender, EventArgs e)
        {

        }

        private void sil_button_f2_Click(object sender, EventArgs e)
        {
            string sorgu2 = "DELETE FROM kisiBilgileri Where ders = @ders"; // id ye göre silme için yazılmış query(sorgu)
            komut = new OleDbCommand(sorgu2, baglanti2);
            komut.Parameters.AddWithValue("@ders", dataGridView2.CurrentRow.Cells[1].Value); //üzerine tıklanılar ıd yi seçerek silme işlemi yapılır
            baglanti2.Open(); // bağlantı açılır
            komut.ExecuteNonQuery(); // sorgu yerine getrilir
            baglanti2.Close(); // bağlantı kapanır
            kisileriListele2(ID_textbox_f2.Text); //son durum listelenir
        }
    }
}