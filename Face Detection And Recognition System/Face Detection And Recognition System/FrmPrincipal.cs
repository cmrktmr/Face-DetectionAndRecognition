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
    public partial class FrmPrincipal : MetroFramework.Forms.MetroForm
    {

        Image<Bgr, Byte> currentFrame;
        Capture grabber;
        HaarCascade face;
        HaarCascade eye;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> NamePersons = new List<string>();
        int ContTrain, NumLabels, t;
        string kullaniciGelenTc, names = null;


        List<csKullaniciBilgileri> kullaniciData = new List<csKullaniciBilgileri>();

        public FrmPrincipal()
        {
            InitializeComponent();
            //Load haarcascades for face detection
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            //eye = new HaarCascade("haarcascade_eye.xml");
            try
            {
     
                  




               DataGuncelle();
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
                MessageBox.Show("Nothing in binary database, please add at least a face(Simply train the prototype with the Add Face Button).", "Triained faces load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

           


        }

        private void DataGuncelle()
        { 

            NumLabels = 0;
            string LoadFaces;
            trainingImages.Clear();
            labels.Clear();
            kullaniciData.Clear();
            StreamReader _dataOku = new StreamReader(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
            while (_dataOku.Peek() != -1)
            {
                NumLabels++;
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

                    kullaniciData.Add(kullanici); ;

                    LoadFaces = "face" + (NumLabels).ToString() + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                    labels.Add(kullanici.tc);
                }

            }

            ContTrain = NumLabels;
             
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialize the capture device
            grabber = new Capture();
            grabber.QueryFrame();
            //Initialize the FrameGraber event
            Application.Idle += new EventHandler(FrameGrabber);
            //tanimabaslatbtn.Enabled = false;
        }

        private void mtKisiEkle_Click(object sender, EventArgs e)
        {
            using (frmKisiEkle frm = new frmKisiEkle())
            {
                frm.ShowDialog();
            
            }
        }


        private void mtBilgiGoruntule_Click(object sender, EventArgs e)
        {
            
       
        
        
        }

        private void mtKisiDuzenle_Click(object sender, EventArgs e)
        {
            frmKisiEkle frm = new frmKisiEkle();
            frm.ShowDialog();

            DataGuncelle();


        }

        private void mtKisiSil_Click(object sender, EventArgs e)
        {

          
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            using (frmFotografYukle frm = new frmFotografYukle())
            {
                frm.ShowDialog();
            
            }
        }

        private void tanimabaslatbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void FrameGrabber(object sender, EventArgs e)
        {

            kamerakisisayisilabel.Text = "0";
            //label4.Text = "";
            NamePersons.Add("");


            //Get the current frame form capture device
            currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            //Convert it to Grayscale
            gray = currentFrame.Convert<Gray, Byte>();

            //Face Detector
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
          face,
          1.2,
          10,
          Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
          new Size(20, 20));

            //Action for each element detected
            foreach (MCvAvgComp f in facesDetected[0])
            {
                t = t + 1;
                result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                //draw the face detected in the 0th (gray) channel with blue color
                currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);


                if (trainingImages.ToArray().Length != 0)
                {
                    //TermCriteria for face recognition with numbers of trained images like maxIteration
                    MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);

                    //Eigen face recognizer
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(
                       trainingImages.ToArray(),
                       labels.ToArray(),
                       3000,
                       ref termCrit);

                    kullaniciGelenTc = recognizer.Recognize(result);
                    
                    
                    csKullaniciBilgileri aktifKullanicibilgisi = kullaniciData.Find(x => x.tc == kullaniciGelenTc);
                     
                    //Draw the label for each face detected and recognized
                    if (aktifKullanicibilgisi == null)
                    {
                        currentFrame.Draw("Tanımsız", ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));
                    }
                    else
                    {
                        currentFrame.Draw(aktifKullanicibilgisi.kullaniciAdi, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));
                    
                    }

                    if (kullaniciGelenTc.Length > 0)
                    {
                        Control[] ekrandaMi = flowLayoutPanel1.Controls.Find("_"+kullaniciGelenTc, false);
                        if (ekrandaMi.Length == 0)
                        {
                             


                            kullaniciControl kullanici = new kullaniciControl();
                            kullanici.Name = "_" + kullaniciGelenTc;

                            kullanici.lblAdi.Text = aktifKullanicibilgisi.kullaniciAdi;
                            kullanici.lblAnne.Text = aktifKullanicibilgisi.anne;
                            kullanici.lblBaba.Text = aktifKullanicibilgisi.baba;
                            kullanici.lblTcNo.Text = aktifKullanicibilgisi.tc;

                            kullanici.lblDogumTarihi.Text = aktifKullanicibilgisi.dogumtarihi;
                            kullanici.lblAdres.Text = aktifKullanicibilgisi.adres;
                            kullanici.lblCinsiyet.Text = aktifKullanicibilgisi.cinsiyet;
                            kullanici.pic_Resim.Image = result;
                            flowLayoutPanel1.Controls.Add(kullanici);
                        }
                        else
                        {
                            ((kullaniciControl)ekrandaMi[0]).pic_Resim.Image = result;
                        }
                    }
                }

                NamePersons[t - 1] = kullaniciGelenTc;
                NamePersons.Add("");


                //Set the number of faces detected on the scene
                kamerakisisayisilabel.Text = facesDetected[0].Length.ToString();

                /*
                //Set the region of interest on the faces
                        
                gray.ROI = f.rect;
                MCvAvgComp[][] eyesDetected = gray.DetectHaarCascade(
                   eye,
                   1.1,
                   10,
                   Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                   new Size(20, 20));
                gray.ROI = Rectangle.Empty;

                foreach (MCvAvgComp ey in eyesDetected[0])
                {
                    Rectangle eyeRect = ey.rect;
                    eyeRect.Offset(f.rect.X, f.rect.Y);
                    currentFrame.Draw(eyeRect, new Bgr(Color.Blue), 2);
                }
                 */

            }
            t = 0;

            //Names concatenation of persons recognized
            for (int nnn = 0; nnn < facesDetected[0].Length; nnn++)
            {
                csKullaniciBilgileri c = kullaniciData.Find(x => x.tc == NamePersons[nnn]);

                if (c != null)
                    names = names + c.kullaniciAdi + ", ";
            }
            //Show the faces procesed and recognized
            imageBoxFrameGrabber.Image = currentFrame;
            kameradakikimlabel.Text = names;
            names = "";
            //Clear the list(vector) of names
            NamePersons.Clear();






        }

        private void yuzeklebtn_Click(object sender, EventArgs e)
        {
           
                frmKisiEkle _yeniKisiForm = new frmKisiEkle();
                _yeniKisiForm.ShowDialog();
                if (_yeniKisiForm.kayitEklendi)
                {
                    //Trained face counter
                    ContTrain = ContTrain + 1;
                    string yeniIsim = _yeniKisiForm.txtAdSoyad.Text;
                    //Get a gray frame from capture device
                    gray = grabber.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                    //Face Detector
                    MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                    face,
                    1.2,
                    10,
                    Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                    new Size(20, 20));

                    //Action for each element detected
                    foreach (MCvAvgComp f in facesDetected[0])
                    {
                        TrainedFace = currentFrame.Copy(f.rect).Convert<Gray, byte>();
                        break;
                    }

                    //resize face detected image for force to compare the same size with the 
                    //test image with cubic interpolation type method
                    TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                    trainingImages.Add(TrainedFace);
                    labels.Add(_yeniKisiForm.txtKimlikNo.Text);

                    //Show face added in gray scale
                    imageBox1.Image = TrainedFace;

                    //Write the number of triained faces in a file text for further load
                    //File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");
                    NumLabels++;
                    //Write the labels of triained faces in a file text for further load
                    trainingImages.ToArray()[trainingImages.Count-1].Save(Application.StartupPath + "/TrainedFaces/face" + NumLabels.ToString() + ".bmp");             
                    MessageBox.Show(yeniIsim + "´s face detected and added :)", "Training OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.DoEvents();
                   DataGuncelle();
                }
        }

    }
}
