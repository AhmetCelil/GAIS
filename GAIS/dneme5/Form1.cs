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
    public partial class Form1 : Form
    {

        public string gonderilenVeri;

        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataAdapter data;

        void kisileriListele()    // kisilerin verilerini listele
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source= dbKisiler.accdb");   // veri tabanının motor sürümü ve konumu tanımlanır
            baglanti.Open();  // bağlantı açma
            data = new OleDbDataAdapter("SELECT *FROM kisiler", baglanti); // kisiler tablosunda bulunan veriler data parametresine atanır
            DataTable tablo = new DataTable();  // tablo oluşturulur
            data.Fill(tablo); // data veri yapısında bulunan tablo verileri tabloya atılır
            dataGridView1.DataSource = tablo; // ilgili tablo datagridview da görüntülernir
            baglanti.Close(); // bağlantı kapama


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void telefon_textbox_f_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void yaz_butonu_f_Click(object sender, EventArgs e) // veirlerin eklendiği buton
        {
            string sorgu = "INSERT INTO kisiler (isim,soyad,telefon,numara) values (@ad,@soyad,@telefon,@tc)";   // kisiler tabloduna insert(ekleme işlemi)
            komut = new OleDbCommand(sorgu , baglanti);
            // veriler textboxa girilir
            komut.Parameters.AddWithValue("@ad", isim_textbox_f.Text);
            komut.Parameters.AddWithValue("@soyad", soyisim_textbox_f.Text);
            komut.Parameters.AddWithValue("@telefon", telefon_textbox_f.Text);
            komut.Parameters.AddWithValue("@tc", tckimlik_textbox_f.Text);


            baglanti.Open(); // bağlantı açılır
            komut.ExecuteNonQuery(); // textboxa girilern veriler ilgili query(dorgu) e göre tabloya aktarılır
            baglanti.Close(); // bağlantı kapanır
            kisileriListele();//son durum listelenir

        }

        private void sil_butonu_f_Click(object sender, EventArgs e) // silme işlemi
        {
            string sorgu2 = "DELETE FROM kisiler Where ID = @id"; // id ye göre silme için yazılmış query(sorgu)
            komut = new OleDbCommand(sorgu2, baglanti);
            komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value); //üzerine tıklanılar ıd yi seçerek silme işlemi yapılır
            baglanti.Open(); // bağlantı açılır
            komut.ExecuteNonQuery(); // sorgu yerine getrilir
            baglanti.Close(); // bağlantı kapanır
            kisileriListele(); //son durum listelenir
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisileriListele(); // form sayfası yüklendiğinde kişiler listelenir
        }

        

        private void guncelle_button_f_Click(object sender, EventArgs e)  // güncellleme işlemini yapan buton
        {
            string sorgu2 = "UPDATE kisiler SET isim = @ad , soyad = @soyisim, telefon= @telefon, numara=@tc WHERE ID=@id"; // güncelleme işlemi için yazılan query
            komut = new OleDbCommand(sorgu2, baglanti);
            //güncellenebilecek veriler
            komut.Parameters.AddWithValue("@ad", isim_textbox_f.Text);
            komut.Parameters.AddWithValue("@soyisim", soyisim_textbox_f.Text);
            komut.Parameters.AddWithValue("@telefon", telefon_textbox_f.Text);
            komut.Parameters.AddWithValue("@tc", tckimlik_textbox_f.Text);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(ID_textbox_f.Text.ToString())); 

            baglanti.Open(); //bağlantı açılır
            komut.ExecuteNonQuery(); // sorgu yerine getirilei
            baglanti.Close(); // bağlantı kapanır
            kisileriListele();  //son durum listelenir
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e) //data gridde bulunan verileri text boxlarda görüntülernir
        {
            // herhangi bir cell de bulunan veriye tıklandığında o satırda bulunan verileri textbox a yazar
            ID_textbox_f.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            isim_textbox_f.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            soyisim_textbox_f.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            telefon_textbox_f.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tckimlik_textbox_f.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void kisiGoruntule_button_f_Click(object sender, EventArgs e)  // kişiye özel bilgilerin ekleme/silme işlemlerinin bulunduğu form a gider
        {
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Kisiler", baglanti);

            DataTable dt = new DataTable();

            baglanti.Open();
            OleDbDataReader oku = komut.ExecuteReader();
     
            gonderilenVeri = oku.ToString();

            Form2 gec = new Form2();

            gec.veriyiGoster(ID_textbox_f.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString()); // ID_textbox_f texboxda bulunan ıd deki 
           // gec.veriFoster_textbox_f2_Click(null,null,ID_textbox_f.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString());
            gec.Show(); // form2 yi göster form1 gizleme

            baglanti.Close() ; // veri tabanı bağlantısını kapa
        }

        private void idGonder()
        {
            

        }

        private void tcsorgu_textbox_f_TextChanged(object sender, EventArgs e) // tc ile sorgulama yapar
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source= dbKisiler.accdb");
            OleDbDataAdapter data2 = new OleDbDataAdapter("SELECT *from kisiler where numara like '"+ tcsorgu_textbox_f.Text + "%'" , baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            data2.Fill(ds, "kisiler");
            dataGridView1.DataSource = ds.Tables["kisiler"];
            baglanti.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
