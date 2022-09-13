using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Stok_Takip__Otomasyonu
{
    public partial class Müşteri_Ekle : Form
    {
        public Müşteri_Ekle()
        {
            InitializeComponent();
        }
        //Sql veritabanına bağlantı kurmak için kullanılacak olduğumuz sınıftır.
       SqlConnection baglantı = new SqlConnection ("Data Source=DESKTOP-HN4JDPF;Initial Catalog = stok_takip; Integrated Security = True");
        private void textBox1_TextChanged(object sender, KeyEventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e) //SqlCommand, T-Sql sorguları ile veritabanı üzerinde sorgulama, ekleme, güncelleme, silme işlemlerini yapmak için kullanılmaktadır.
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into müşteri(tc,adsoyad,telefon,adres,email)values(@tc,@adsoyad,@telefon,@adres,@email)", baglantı);
            komut.Parameters.AddWithValue("@tc", txttc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
            komut.Parameters.AddWithValue("adres", txtadres.Text);
            komut.Parameters.AddWithValue("@email", txtemail.Text);
            komut.ExecuteNonQuery();   //işlemi onaylayan kod
            baglantı.Close();
            MessageBox.Show("Müşteri Kayıt Edildi");
            foreach (Control item in this.Controls) // textbox taki yazıları siler
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                   


            }
                   
        }

        private void txttc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
