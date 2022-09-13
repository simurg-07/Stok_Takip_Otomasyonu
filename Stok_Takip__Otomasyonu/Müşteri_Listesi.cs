using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip__Otomasyonu
{
    public partial class Müşteri_Listesi : Form
    {
        public Müşteri_Listesi()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-HN4JDPF;Initial Catalog = stok_takip; Integrated Security = True");
        DataSet daset = new DataSet(); // geçici olarak kayıt tutma
        private void Müşteri_Listesi_Load(object sender, EventArgs e)
        {
            Kayıt_Göster();
        }

        private void txttcara_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // textbox a sadece sayı yazma komutu
        }

        private void Kayıt_Göster()
        {
            baglantı.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from müşteri", baglantı); //müşterş tablosundaki kayıtları göster
            adtr.Fill(daset, "müşteri");
            dataGridView1.DataSource = daset.Tables["müşteri"];
            baglantı.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)  
        {
            txttc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();         //tablodaki bilgiler
            txtadsoyad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            txttelefon.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtadres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txtemail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();  // update=komut müşteri=tablo set=değişecek olanlar where= neye göre
            SqlCommand komut = new SqlCommand("Update müşteri set adsoyad=@adsoyad, telefon=@telefon, adres=@adres, email=@email where tc=@tc", baglantı); // verileri güncelleme

            komut.Parameters.AddWithValue("@tc", txttc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
            komut.Parameters.AddWithValue("adres", txtadres.Text);
            komut.Parameters.AddWithValue("@email", txtemail.Text);
            komut.ExecuteNonQuery();   //işlemi onaylayan kod
            baglantı.Close();
            MessageBox.Show("Müşteri güncellendi");
            foreach (Control item in this.Controls) // textbox taki yazıları siler
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("delete from müşteri where tc='" + dataGridView1.CurrentRow.Cells["tc"].Value.ToString()+"'", baglantı);

            komut.ExecuteNonQuery();   //işlemi onaylayan kod
            daset.Tables["müşteri"].Clear(); // tabloyu silme
            Kayıt_Göster();
            MessageBox.Show("Müşteri silindi");
           
        }

        private void txttcara_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();  
            baglantı.Open();
            SqlDataAdapter adtr = new SqlDataAdapter ("select *from müşteri where tc like'%" + txttcara.Text + "%'", baglantı);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo; //datasource veritabanına erişir
            baglantı.Close();
            // burdaki % değeri girilen kelime ile eşleşen tüm kayıtları gösterir 
        }

        
    }
}
