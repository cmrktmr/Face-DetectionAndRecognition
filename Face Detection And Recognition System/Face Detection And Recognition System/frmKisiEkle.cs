using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Diagnostics;


namespace Face_Detection_And_Recognition_System
{
    public partial class frmKisiEkle : MetroFramework.Forms.MetroForm
    {


        public frmKisiEkle()
        {
            InitializeComponent();
        }

        private void metroTextBox6_Click(object sender, EventArgs e)
        {

        }

        private void btnYuzAl_Click(object sender, EventArgs e)
        {
            //Initialize the capture device

        }

        private void FrameGrabber(object sender, EventArgs e)
        {


        }
        public bool kayitEklendi = false;
        void datayiKaydet()
        {
            System.IO.StreamWriter sr = new StreamWriter(Application.StartupPath + @"\TrainedFaces\TrainedLabels.txt", false);

            foreach (csKullaniciBilgileri item in kullaniciListesi)
            {
                sr.WriteLine(String.Format("{0}%{1}%{2}%{3}%{4}%{5}%{6}%{7}",
                    item.kullaniciAdi,
                    item.tc,
                    item.dogumtarihi,
                    item.cinsiyet,
                    item.dogumyeri,
                    item.anne,
                    item.baba,
                    item.adres));
            }

            sr.Close();
        }
        bool tcKontrol(string tc)
        {
            string tcKimlikNo = tc;
            bool returnvalue = false;
            if (tcKimlikNo.Length == 11)
            {
                Int64 ATCNO, BTCNO, TcNo;
                long C1, C2, C3, C4, C5, C6, C7, C8, C9, Q1, Q2;

                TcNo = Int64.Parse(tcKimlikNo);

                ATCNO = TcNo / 100;
                BTCNO = TcNo / 100;

                C1 = ATCNO % 10; ATCNO = ATCNO / 10;
                C2 = ATCNO % 10; ATCNO = ATCNO / 10;
                C3 = ATCNO % 10; ATCNO = ATCNO / 10;
                C4 = ATCNO % 10; ATCNO = ATCNO / 10;
                C5 = ATCNO % 10; ATCNO = ATCNO / 10;
                C6 = ATCNO % 10; ATCNO = ATCNO / 10;
                C7 = ATCNO % 10; ATCNO = ATCNO / 10;
                C8 = ATCNO % 10; ATCNO = ATCNO / 10;
                C9 = ATCNO % 10; ATCNO = ATCNO / 10;
                Q1 = ((10 - ((((C1 + C3 + C5 + C7 + C9) * 3) + (C2 + C4 + C6 + C8)) % 10)) % 10);
                Q2 = ((10 - (((((C2 + C4 + C6 + C8) + Q1) * 3) + (C1 + C3 + C5 + C7 + C9)) % 10)) % 10);

                returnvalue = ((BTCNO * 100) + (Q1 * 10) + Q2 == TcNo);
            }


            if (returnvalue)
                return true;
            else
                return false;
        }
        private void btnKisiEkle_Click(object sender, EventArgs e)
        {
            if (tcKontrol(txtKimlikNo.Text) == true)
            {

                csKullaniciBilgileri kullaniciKontrol = kullaniciListesi.Find(x => x.tc == txtKimlikNo.Text);
                if (kullaniciKontrol == null)
                {
                    kullaniciKontrol = new csKullaniciBilgileri();
                    kullaniciKontrol.adres = richtxtAdres.Text;
                    kullaniciKontrol.anne = txtAnaAdiSoyadi.Text;
                    kullaniciKontrol.baba = txtBabaAdiSoyadi.Text;
                    kullaniciKontrol.cinsiyet = cbCinsiyet.Text;
                    kullaniciKontrol.dogumtarihi = dateTimePickerDogumTarihi.Value.ToShortDateString();
                    kullaniciKontrol.dogumyeri = txtDogumYeri.Text;
                    kullaniciKontrol.kullaniciAdi = txtAdSoyad.Text;
                    kullaniciKontrol.tc = txtKimlikNo.Text;
                    kullaniciListesi.Add(kullaniciKontrol);
                }
                else
                {
                    kullaniciKontrol.adres = richtxtAdres.Text;
                    kullaniciKontrol.anne = txtAnaAdiSoyadi.Text;
                    kullaniciKontrol.baba = txtBabaAdiSoyadi.Text;
                    kullaniciKontrol.cinsiyet = cbCinsiyet.Text;
                    kullaniciKontrol.dogumtarihi = dateTimePickerDogumTarihi.Value.ToShortDateString();
                    kullaniciKontrol.dogumyeri = txtDogumYeri.Text;
                    kullaniciKontrol.kullaniciAdi = txtAdSoyad.Text;
                    kullaniciKontrol.tc = txtKimlikNo.Text;

                    kullaniciListesi[cmbKullaniciListesi.SelectedIndex] = kullaniciKontrol;

                }

                datayiKaydet();
                kayitEklendi = true;
                Close();
            }
            else
            {
                MessageBox.Show("Geçersiz TC no");
            }
        }
        List<csKullaniciBilgileri> kullaniciListesi = new List<csKullaniciBilgileri>();
        private void frmKisiEkle_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt"))
            {
                StreamReader _dataOku = new StreamReader(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
                while (_dataOku.Peek() != -1)
                {
                    string[] gelenSatir = _dataOku.ReadLine().Split('%');
                    if (gelenSatir.Length > 2)
                    {
                        csKullaniciBilgileri kullanici = new csKullaniciBilgileri();

                        kullanici.cinsiyet = gelenSatir[3];
                        kullanici.kullaniciAdi = gelenSatir[0];
                        kullanici.anne = gelenSatir[5];
                        kullanici.baba = gelenSatir[6];
                        kullanici.dogumtarihi = gelenSatir[4];
                        kullanici.tc = gelenSatir[1];
                        kullanici.adres = gelenSatir[7];
                        kullaniciListesi.Add(kullanici); ;
                    }

                }

                cmbKullaniciListesi.DataSource = kullaniciListesi;
                cmbKullaniciListesi.DisplayMember = "kullaniciAdi";
                cmbKullaniciListesi.DisplayMember = "tc";
                cmbKullaniciListesi.SelectedIndex = -1;


                txtKimlikNo.Text = "";
                txtDogumYeri.Text = "";
                txtBabaAdiSoyadi.Text = "";
                txtAnaAdiSoyadi.Text = "";
                txtAdSoyad.Text = "";
                cbCinsiyet.Text = "";
                richtxtAdres.Text = "";
            }
        }

        private void cmbKullaniciListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                csKullaniciBilgileri kullanici = kullaniciListesi[cmbKullaniciListesi.SelectedIndex];
                txtKimlikNo.Text = kullanici.tc;
                txtDogumYeri.Text = kullanici.dogumyeri;
                txtBabaAdiSoyadi.Text = kullanici.baba;
                txtAnaAdiSoyadi.Text = kullanici.anne;
                txtAdSoyad.Text = kullanici.kullaniciAdi;
                cbCinsiyet.Text = kullanici.cinsiyet;
                richtxtAdres.Text = kullanici.adres;
                dateTimePickerDogumTarihi.Value = Convert.ToDateTime(kullanici.dogumtarihi);
            }
            catch (Exception)
            {
                 
            }
        }
    }
}
