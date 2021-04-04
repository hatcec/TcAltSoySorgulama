using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcAltSoySorgulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string sonuc;
        string TCNO;
        int on_sayi;
        long TC;
        public string TcKontrolAlt(string TCNO)
        {
            String birinci = TCNO.Substring(0, 5);
            String ikinci = TCNO.Substring(5, 4);
            String ücüncü = TCNO.Substring(10, 1);
            int kisim1 = Convert.ToInt32(birinci) - 3;
            int kisim2 = Convert.ToInt32(ikinci) + 1;
            int kisim3 = Convert.ToInt32(ücüncü);
            if (birinci.Substring(2, 1) == kisim1.ToString().Substring(2, 1))
            {
                if (ikinci.Substring(1, 1) == kisim2.ToString().Substring(1, 1))
                {
                    kisim3 += 4;
                }
                else
                {
                    kisim3 += 2;
                }
            }
            else
            {
                kisim3 += 6;
            }
            int basamak1 = 0;
            int toplam = 0;
            int sayi1 = kisim1;
            for (int i = 0; i < 5; i++)
            {
                basamak1 = sayi1 % 10;
                sayi1 = sayi1 / 10;
                toplam += basamak1;
            }
            int basamak2 = 0;
            int sayi2 = kisim2;
            for (int i = 0; i < 4; i++)
            {
                basamak2 = sayi2 % 10;
                sayi2 = sayi2 / 10;
                toplam += basamak2;
            }
            int a = Convert.ToInt32(toplam) % 10;
            int kontrol = 0;
            int k = 0;
            if (kisim3 >= 10)
            {
                kisim3 = kisim3 % 10;
                k = k + 1;
            }
            else
            {
                on_sayi = 0;
            }
            if (a == kisim3)
            {
                kontrol = kisim3 % 10;
                sonuc = kisim1.ToString() + "" + kisim2.ToString() + "" + on_sayi.ToString() + "" + kontrol.ToString();
            }
            else
            {
                if (a < kisim3)
                {
                    on_sayi = k + kisim3 - a;
                }
                else
                {
                    on_sayi = k + a - kisim3;
                }
                if (on_sayi > 10)
                {
                    kisim2 += 1;
                    kontrol = kisim3 % 10;
                    sonuc = kisim1.ToString() + "" + kisim2.ToString() + "" + on_sayi.ToString() + "" + kontrol.ToString();
                }
                else
                {
                    kontrol = kisim3 % 10;
                    sonuc = kisim1.ToString() + "" + kisim2.ToString() + "" + on_sayi.ToString() + "" + kontrol.ToString();
                }
            }

            if (kisim3 % 2 != 0)
            {
                return TcKontrolAlt(sonuc);
            }
            else
            {
                return sonuc;
            }
        }
        private void TxtTc_Enter(object sender, EventArgs e)
        {
            if (TxtTc.Text == "Kimlik Numarası Giriniz..")
            {
                TxtTc.Text = "";
                TxtTc.ForeColor = Color.Black;
            }
        }

        private void TxtTc_Leave(object sender, EventArgs e)
        {
            if (TxtTc.Text == "")
            {
                TxtTc.Text = "Kimlik Numarası Giriniz..";
                TxtTc.ForeColor = Color.Silver;
            }
        }

        private void TxtAd_Enter(object sender, EventArgs e)
        {
            if (TxtAd.Text == "İsim Giriniz..")
            {
                TxtAd.Text = "";
                TxtAd.ForeColor = Color.Black;
            }

        }

        private void TxtAd_Leave(object sender, EventArgs e)
        {
            if (TxtAd.Text == "")
            {
                TxtAd.Text = "İsim Giriniz..";
                TxtAd.ForeColor = Color.Silver;
            }
        }

        private void TxtSoyad_Enter(object sender, EventArgs e)
        {
            if (TxtSoyad.Text == "Soyisim Giriniz..")
            {
                TxtSoyad.Text = "";
                TxtSoyad.ForeColor = Color.Black;
            }
        }

        private void TxtSoyad_Leave(object sender, EventArgs e)
        {
            if (TxtSoyad.Text == "")
            {
                TxtSoyad.Text = "Soyisim Giriniz..";
                TxtSoyad.ForeColor = Color.Silver;
            }
        }

        private void TxtTarih_Enter(object sender, EventArgs e)
        {
            if (TxtTarih.Text == "Doğum Tarihi Giriniz..")
            {
                TxtTarih.Text = "";
                TxtTarih.ForeColor = Color.Black;
            }
        }

        private void TxtTarih_Leave(object sender, EventArgs e)
        {
            if (TxtTarih.Text == "")
            {
                TxtTarih.Text = "Doğum Tarihi Giriniz..";
                TxtTarih.ForeColor = Color.Silver;
            }
        }

        private void BtnSorgula_Click(object sender, EventArgs e)
        {
            TCNO = TxtTc.Text;
            string kimlikno = TcKontrolAlt(TCNO);
            bool durum = false;

            while (durum != true)
            {
                using (KimlikSorgulama.KPSPublicSoapClient service = new KimlikSorgulama.KPSPublicSoapClient())
                {
                    TC = Convert.ToInt64(kimlikno);
                    durum = service.TCKimlikNoDogrula(TC, TxtAd.Text.ToUpper(), TxtSoyad.Text.ToUpper(), Convert.ToInt32(TxtTarih.Text));
                    string d = TC.ToString();
                    kimlikno = TcKontrolAlt(d);
                }
            }
            string F = TC.ToString();
            MessageBox.Show(durum.ToString() +"  --  Tc Kimlik Numarası: " + F);

        }
    }
}
