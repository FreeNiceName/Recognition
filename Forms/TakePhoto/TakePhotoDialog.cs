using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Recognition
{
    public partial class TakePhotoDialog : Form
    {
        private VideoCaptureDevice _camera;

        public Image Image { get; set; }

        public TakePhotoDialog()
        {
            InitializeComponent();
            cbDevice.DataSource = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            cbDevice.DisplayMember = "Name";
        }

        private void StopCapture()
        {
            if (_camera == null) return;

            _camera.NewFrame -= device_NewFrame;
            _camera.SignalToStop();
        }

        private void btTakePhoto_Click(object sender, EventArgs e)
        {
            Image = pbWebcam.Image;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void device_NewFrame(object sender, NewFrameEventArgs e)
        {
            if (pbWebcam.Image != null)
                pbWebcam.Image.Dispose();

            pbWebcam.Image = (Image)e.Frame.Clone();
        }

        private void TakePhotoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.OnClosed(e);
            StopCapture();
        }

        private void cbDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            StopCapture();

            var filter = cbDevice.SelectedItem as FilterInfo;
            _camera = new VideoCaptureDevice(filter.MonikerString);
            _camera.NewFrame += device_NewFrame;
            _camera.Start();
        }
    }
}
