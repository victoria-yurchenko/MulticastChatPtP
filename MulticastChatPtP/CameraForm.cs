using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MulticastChatPtP
{
    public partial class CameraForm : Form
    {
        private bool _canCloseTheForm;
        private VideoCapture _capture;
        private Mat _frame;
        private Bitmap _image;
        private bool _isActive;
        private string _imageDirectory = string.Empty;

        public string ImagePath { get; set; }

        public CameraForm()
        {
            InitializeComponent();
            _canCloseTheForm = false;
            _isActive = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            _imageDirectory = Directory.GetCurrentDirectory();
            btnCaptureCamera.Enabled = false;
        }

        private void btnStartStream_Click(object sender, EventArgs e)
        {
            if (btnStartStream.Text.StartsWith("Start"))
                StartCapture();
            else
                StopCapture();
        }

        private void StartCapture()
        {
            CaptureCamera();
            _isActive = true;
            btnStartStream.Text = "Stop Capture";
            _canCloseTheForm = false;
        }

        private void StopCapture()
        {
            _isActive = false;
            btnStartStream.Text = "Start Stream";
            _capture.Release();
            _canCloseTheForm = true;
        }

        private void CaptureCamera()
        {
            var thread = new Thread(DoCamera);
            thread.IsBackground = true;
            thread.Start();
        }

        private void DoCamera(object obj)
        {
            try
            {
                _frame = new Mat();
                _capture = new VideoCapture(0);
                _capture.Open(0);

                if (_capture.IsOpened())
                {
                    while (_isActive)
                    {
                        if (IsDisposed)
                            return;

                        Invoke((MethodInvoker)delegate
                        {
                            btnCaptureCamera.Enabled = true;
                        });
                        _capture.Read(_frame);
                        _image = BitmapConverter.ToBitmap(_frame);
                        if (IsDisposed)
                            return;
                        Invoke((MethodInvoker)delegate ()
                        {
                            if (pictureBox1.Image != null)
                                pictureBox1.Image = null;

                            pictureBox1.Image = _image;
                        });
                    }
                }
                else
                {
                    Invoke((MethodInvoker)delegate
                    {
                        btnCaptureCamera.Enabled = false;
                    });
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot close the window!");
            }
        }

        private void btnCaptureCamera_Click(object sender, EventArgs e)
        {
            var bitmap = new Bitmap(pictureBox1.Image);
            var fileName = $"{DateTimeOffset.Now.ToUnixTimeMilliseconds()}_img.jpg";
            var filePath = Path.Combine(_imageDirectory, fileName);
            bitmap.Save(filePath, ImageFormat.Jpeg);
            Form1._path = filePath;
        }

        private void CameraForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (_canCloseTheForm)
                e.Cancel = false;
            else
                MessageBox.Show("Cannot close the window without closing the livestream!");
        }
    }
}
