using Emgu.CV;
using Emgu.CV.Structure;
using HotelManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class FormLoginFace : Form
    {
        private VideoCapture _capture = null;
        private CascadeClassifier _faceDetector;
        private Bitmap _capturedFace;

        public FormLoginFace()
        {
            InitializeComponent();

            // Load cascade detect mặt (để trong thư mục dự án)
            _faceDetector = new CascadeClassifier(@"C:\Users\nguye\Desktop\HotelManagement\HotelManagement\HotelManagement\haarcascade_frontalface_default.xml");

            try
            {
                _capture = new VideoCapture(0);
                _capture.ImageGrabbed += ProcessFrame;
                _capture.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot start camera: " + ex.Message);
            }
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            Mat frame = new Mat();
            _capture.Retrieve(frame);

            if (frame.IsEmpty)
                return;

            var image = frame.ToImage<Bgr, byte>();
            var gray = image.Convert<Gray, byte>();
            var faces = _faceDetector.DetectMultiScale(gray, 1.1, 4, Size.Empty);

            if (faces.Length > 0)
            {
                var faceRect = faces[0];
                image.Draw(faceRect, new Bgr(Color.Green), 2);

                var faceImg = image.Copy(faceRect).Resize(100, 100, Emgu.CV.CvEnum.Inter.Cubic);
                _capturedFace = faceImg.ToBitmap();

                pictureBoxFace.Image = _capturedFace;
            }
            else
            {
                _capturedFace = null;
                pictureBoxFace.Image = null;
            }

            pictureBoxCamera.Image = image.ToBitmap();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_capturedFace == null)
            {
                MessageBox.Show("No face detected. Please try again.");
                return;
            }

            LoginWithFaceID(_capturedFace);
        }

        private void LoginWithFaceID(Bitmap loginFace)
        {
            UserRepository userRepo = new UserRepository();
            var allUsers = userRepo.GetAllUsersWithFaceID(); // Danh sách {EmployeeID, FaceID byte[]}

            foreach (var user in allUsers)
            {
                Bitmap storedFace = ByteArrayToBitmap(user.FaceID);
                double mse = CalculateMSE(loginFace, storedFace);

                if (mse < 5000)  // Ngưỡng tùy chỉnh, bạn test để phù hợp
                {
                    MessageBox.Show($"Login successful! Welcome Employee {user.EmployeeID}");
                    // TODO: Xử lý đăng nhập, chuyển màn hình...
                    return;
                }
            }

            MessageBox.Show("Face not recognized. Login failed.");
        }

        private Bitmap ByteArrayToBitmap(byte[] bytes)
        {
            using (var ms = new System.IO.MemoryStream(bytes))
            {
                return new Bitmap(ms);
            }
        }

        private double CalculateMSE(Bitmap img1, Bitmap img2)
        {
            if (img1.Width != img2.Width || img1.Height != img2.Height)
                return double.MaxValue;

            double mse = 0;

            for (int y = 0; y < img1.Height; y++)
            {
                for (int x = 0; x < img1.Width; x++)
                {
                    Color c1 = img1.GetPixel(x, y);
                    Color c2 = img2.GetPixel(x, y);

                    int diffR = c1.R - c2.R;
                    int diffG = c1.G - c2.G;
                    int diffB = c1.B - c2.B;

                    mse += diffR * diffR + diffG * diffG + diffB * diffB;
                }
            }

            mse /= (img1.Width * img1.Height * 3);
            return mse;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_capture != null)
            {
                _capture.ImageGrabbed -= ProcessFrame;
                _capture.Dispose();
                _capture = null;
            }
            base.OnFormClosing(e);
        }
    }
}
