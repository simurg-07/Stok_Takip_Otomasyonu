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
    public partial class Marka_Sayfası : Form
    {
        public Marka_Sayfası()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HN4JDPF;Initial Catalog=stok_takip;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open(); //insert = ekle into = nerden value= değeri nerden alıcak
            SqlCommand komut = new SqlCommand("insert into markabilgileri(kategori,marka) values('" + comboBox1 + "','" + textBox1.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            textBox1.Text = "";
            comboBox1.Text = "";
            MessageBox.Show("marka eklendi");
        }


        private void kategorigetir() // bir metod oluşturduk. bu şekilde metod oluşturabilirsin ve az kod yazarsın
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();              //SqlDataReader sadece okunabilir olarak kullanılmaktadır nesnesi Read() metodudur.
            while (read.Read()) // okunacagı zaman
            {
                comboBox1.Items.Add(read["kategori"].ToString()); //kategorideki itemleri combobox1 e ekle
            }
            baglanti.Close();
        }
        private void Marka_Sayfası_Load(object sender, EventArgs e) //kategorilerin combobox1 e gelmesi
        {
            kategorigetir();        //burda oluşturduğumuz metodu kullanıyoruz
        }


    }
}
