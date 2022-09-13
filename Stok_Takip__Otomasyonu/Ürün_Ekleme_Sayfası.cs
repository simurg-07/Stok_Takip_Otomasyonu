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
    public partial class Ürün_Ekleme_Sayfası : Form
    {
        public Ürün_Ekleme_Sayfası()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HN4JDPF;Initial Catalog=stok_takip;Integrated Security=True");
        private void kategorigetir() // bir metod oluşturduk. bu şekilde metod oluşturabilirsin ve az kod yazarsın
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();              //SqlDataReader sadece okunabilir olarak kullanılmaktadır nesnesi Read() metodudur.
            while (read.Read()) // okunacagı zaman
            {
                comboKategori.Items.Add(read["kategori"].ToString()); //kategorideki itemleri comboKategoriye  ekle
            }
            baglanti.Close();
        }

        private void Ürün_Ekleme_Sayfası_Load(object sender, EventArgs e)
        {
            kategorigetir(); 
        }
        

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                comboMarka.Items.Clear(); //içini temizler
                comboMarka.Text = "";  // boş bırakır
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from markabilgileri where kategori='"+ comboKategori.SelectedItem +"'", baglanti); // seçili kategorideki ürünleri gösterir
                SqlDataReader read = komut.ExecuteReader();  //SqlDataReader sadece okunabilir olarak kullanılmaktadır nesnesi Read() metodudur.
                while (read.Read()) // okunacagı zaman
                {
                    comboMarka.Items.Add(read["marka"].ToString()); // itemleri combobox1 e ekle      select *from markabilgileri where kategori='"
            }
                baglanti.Close();
            }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into urun(barkodno,kategori,marka,urunadi,miktari,alisfiyati,satisfiyati,tarih) values(@barkodno,@kategori,@marka,@urunadi,@miktari,@alisfiyati,@satisfiyati,@tarih)", baglanti);
            komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
            komut.Parameters.AddWithValue("@marka", comboMarka.Text);
            komut.Parameters.AddWithValue("@urunadi", txtÜrünAdı.Text);
            komut.Parameters.AddWithValue("@miktari", int.Parse(txtMiktarı.Text)); // sadece tamsayı girebilirsin
            komut.Parameters.AddWithValue("@alisfiyati", double.Parse(txtAlışFiyatı.Text)); // ondalık sayıda girebilirsin
            komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatışFiyatı.Text)); // ondalık sayıda girebilirsin
            komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString()); // bugünün tarihi ve zamanını gösteren komut
           
            komut.ExecuteNonQuery(); //komutu onaylıyor
            baglanti.Close();
            MessageBox.Show("Ürün Eklendi");
            comboMarka.Items.Clear(); // temizlendikten sonra itemleri silmek için

            foreach(Control item in groupBox1.Controls) // groupBox1 i teker teker dolaiıyor 
            {
                if(item is TextBox ) // textboxları boş bıraktık
                {
                    item.Text = "";
                }

                if (item is ComboBox) // combobboxları boş bıraktık
                {
                    item.Text = "";
                }

            }

        }

        private void BarkodNotxt_TextChanged(object sender, EventArgs e)
        {
            if (BarkodNotxt.Text == "") 
            {
                lblmiktar.Text = "";
                foreach ( Control item in groupBox2.Controls) //groupBox2 yi teker teker dolaiıyor
                    {
                    if(item is TextBox)
                        {
                            item.Text = "";
                        }
                    }
            }

            baglanti.Open(); // like = Sql sorgularında kullanılan Like komutu WHERE ifadesiyle beraber kullanılan ve veritabanındaki kayıtlarda belirli bir deseni aramak için sıkça kullanılan bir ifadedir.
            SqlCommand komut = new SqlCommand("select *from urun where barkodno like '"+ BarkodNotxt.Text+ "'",baglanti);  // seçili kategorideki ürünleri gösterir
            SqlDataReader read = komut.ExecuteReader();  //SqlDataReader sadece okunabilir olarak kullanılmaktadır nesnesi Read() metodudur.
            while (read.Read())  // gösteriyo işte
            {
                Kategoritxt.Text = read["kategori"].ToString();
                Markatxt.Text = read["marka"].ToString();
                ÜrünAdıtxt.Text = read["urunadi"].ToString();
                lblmiktar.Text = read["miktari"].ToString();
                AlışFiyatıtxt.Text = read["alisfiyati"].ToString();
                SatışFiyatıtxt.Text = read["satisfiyati"].ToString();
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set miktari = miktari+'"+int.Parse(Miktarıtxt.Text)+"' where barkodno ='"+BarkodNotxt.Text+"'",baglanti); // güncelleme komutu (üstüne ekliyor)
            komut.ExecuteNonQuery();
            baglanti.Close();

            foreach (Control item in groupBox2.Controls) //groupBox2 yi teker teker dolaiıyor
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            MessageBox.Show("Var Olan Ürüne Güncelleme Yapıldı");
        }
    }
 }

