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
    public partial class Kategori_Sayfası : Form
    {
        public Kategori_Sayfası()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HN4JDPF;Initial Catalog=stok_takip;Integrated Security=True");
        

        private void Kategori_Sayfası_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open(); //insert = ekle into = nerden value= değeri nerden alıcak
            SqlCommand komut = new SqlCommand("insert into kategoribilgileri(kategori) values('"+textBox1.Text+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            textBox1.Text = "";
            MessageBox.Show("kategori eklendi");
        }

       
    }
}
