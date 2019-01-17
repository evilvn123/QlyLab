using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;

namespace QlyLab
{
    public partial class ScanQRcode : Form
    {
        FilterInfoCollection CaptureDevice;
        VideoCaptureDevice FinalFrame;
        public ScanQRcode()
        {
            InitializeComponent();
            openFileDialog1.Title = "Select Picture";
            openFileDialog1.Filter = "PNG Image|*.png|JPEG Image|*.jpg|All Files|*.*";
        }

        private void decode_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Stop();
            label1.Hide();
            cbxTenCamera.Hide();
            btnketnoi.Hide();
            pictureBox1.Hide();
            txtresult.Show();
            btndecode.Show();
            btnfile.Show();
            btnclear.Show();
            pictureBox2.Image = null;
            pictureBox2.Show();
            
            if (FinalFrame != null && FinalFrame.IsRunning)
            {
                FinalFrame.Stop();
            }
            pictureBox2.Image = null;
        }

        private void btnfile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {

                Image img = Image.FromFile(openFileDialog1.FileName);

                pictureBox2.Image = img;
                pictureBox2.Width = img.Width;
                pictureBox2.Height = img.Height;
            }
        }

        private void btndecode_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("Bạn chưa thêm ảnh");
            }
            else
            {
                try
                {
                    QRCodeDecoder decoder = new QRCodeDecoder();
                    txtresult.Text = decoder.Decode(new QRCodeBitmapImage(pictureBox2.Image as Bitmap));
                }
                catch { MessageBox.Show("Ảnh không đúng!");}
            }
        }

        private void ScanQRcode_Load(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            btndecode.Hide();
            btnfile.Hide();
            btnketnoi.Hide();
            label1.Hide();
            cbxTenCamera.Hide();
            txtresult.Hide();
            btnclear.Hide();
            pictureBox2.Hide();
        }

        private void Scan_Click(object sender, EventArgs e)
        {
            label1.Show();
            pictureBox1.Show();
            txtresult.Show();
            btnfile.Hide();
            btndecode.Hide();
            cbxTenCamera.Show();
            btnketnoi.Show();
            btnclear.Show();
            pictureBox2.Hide();
            pictureBox1.Image = null;
           
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                cbxTenCamera.Items.Add(Device.Name);
            }
            cbxTenCamera.SelectedIndex = 0;
            
        }

        private void btnketnoi_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[cbxTenCamera.SelectedIndex].MonikerString);
            FinalFrame.NewFrame +=FinalFrame_NewFrame;
            FinalFrame.Start();
            timer1.Enabled = true;
            timer1.Start();
            try
                {
                    QRCodeDecoder decoder = new QRCodeDecoder();
                    txtresult.Text = decoder.Decode(new QRCodeBitmapImage(pictureBox1.Image as Bitmap));
                }
            catch (Exception ex){ }
        }

        void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bm = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bm;
        }

        private void ScanQRcode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame != null && FinalFrame.IsRunning)
            {
                FinalFrame.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader read = new BarcodeReader();
            if(pictureBox1.Image!=null)
            {
                Result res = read.Decode((Bitmap)pictureBox1.Image);
                try 
                {

                    txtresult.Text = res.ToString();
                    
                }
                catch (Exception ex) { }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtresult.Text = "";
           
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Qlythietbi form = new Qlythietbi();
            form.ShowDialog();
        }
    }
}
