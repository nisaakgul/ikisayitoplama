using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_sayıyı_toplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int Sayi1 =Convert.ToInt32(txtSayi1.Text);
            int Sayi2 =Convert.ToInt32(txtSayi2.Text);

            int Sonuc = Sayi1 + Sayi2;

            lblSonuc.Text=Sonuc.ToString(); 

        }
    }
}
