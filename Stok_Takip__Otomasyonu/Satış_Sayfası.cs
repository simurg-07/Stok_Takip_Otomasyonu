using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip__Otomasyonu
{
	public partial class Satış_Sayfası : Form
	{
		public Satış_Sayfası()
		{
			InitializeComponent();
		}

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Müşteri_Ekle ekle = new Müşteri_Ekle();  // butona basınca yazana sayfaya yönlendirir
            ekle.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Müşteri_Listesi listele = new Müşteri_Listesi();
            listele.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ürün_Ekleme_Sayfası ekle = new Ürün_Ekleme_Sayfası();
            ekle.ShowDialog();
        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Satış_Sayfası_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Kategori_Sayfası ekle = new Kategori_Sayfası();
            ekle.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Marka_Sayfası ekle = new Marka_Sayfası();
            ekle.ShowDialog();
        }
    }
}
