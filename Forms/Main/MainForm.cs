using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Recognition.Properties;

namespace Recognition
{
    public partial class MainForm : Form
    {
        private const string tempFileName = "temp.bmp";

        private IRecognition _recognition;

        public MainForm()
        {
            InitializeComponent();
            panelPhotoUpload.Visible = false;
            panelResult.Visible = false;
        }

        private void btFingerprint_Click(object sender, EventArgs e)
        {
            ShowRecognition(new FingerprintRecognition());
            btTakePhoto.Visible = false;
        }

        private void btFace_Click(object sender, EventArgs e)
        {
            ShowRecognition(new FaceRecognition());
            btTakePhoto.Visible = true;
        }

        private void btIris_Click(object sender, EventArgs e)
        {
            ShowRecognition(new IrisRecognition());
            btTakePhoto.Visible = true;
        }

        private void ShowRecognition(IRecognition recognition)
        {
            _recognition = recognition;
            panelPhotoUpload.Visible = true;
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            panelPhotoUpload.Visible = false;
        }

        private void btPhotoUpload_Click(object sender, EventArgs e)
        {
            using (var openFile = new OpenFileDialog())
            {
                openFile.InitialDirectory = "c:\\";
                openFile.Filter = "All files (*.*)|*.*|Image files (*.jpg;*.jpeg;*.bmp;*.png)|*.jpg;*.jpeg;*.bmp;*.png";
                openFile.FilterIndex = 2;
                openFile.RestoreDirectory = true;

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFile.FileName;
                    Recognition(filePath);
                }
            }
        }

        private void btTakePhoto_Click(object sender, EventArgs e)
        {
            using(var takePhoto = new TakePhotoDialog())
            {
                if(takePhoto.ShowDialog() == DialogResult.OK)
                {
                    var image = new Bitmap(takePhoto.Image);
                    image.Save(tempFileName);
                    image.Dispose();
                    Recognition(tempFileName);
                }
            }
        }

        public async void Recognition(string imagePath)
        {
            panelPhotoUpload.Visible = false;
            panelResult.Visible = true;
            ResetResultPanel();

            var result = await Task.Run(() => _recognition.Run(imagePath));
            ShowResult(result);

            btResultBack.Visible = true;
        }

        private void ResetResultPanel()
        {
            btResultBack.Visible = false;
            pbResult.Image = Resources.loading;
            lbResult.Text = $"Loading...";
            lbResult.ForeColor = Color.Black;
        }

        private void ShowResult(RecognitionResult result)
        {
            if (result.IsAccessGiven)
            {
                pbResult.Image = Resources.checkmark;
                lbResult.Text = $"Access granted to {result.Name}";
                lbResult.ForeColor = Color.Green;
            }
            else
            {
                pbResult.Image = Resources.xmark;
                lbResult.Text = "Access denied";
                lbResult.ForeColor = Color.Red;
            }
        }

        private void btResultBack_Click(object sender, EventArgs e)
        {
            panelResult.Visible = false;
            panelPhotoUpload.Visible = true;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (File.Exists(tempFileName))
                File.Delete(tempFileName);
        }
    }
}
