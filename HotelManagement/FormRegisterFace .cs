using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using HotelManagement.Repositories;
using System;
using System.Drawing;
using System.Windows.Forms;
using static HotelManagement.FormLogin;

namespace HotelManagement
{
    public partial class FormRegisterFace : Form
    {
        private VideoCapture _capture = null;
        private CascadeClassifier _faceDetector;
        private Bitmap _capturedFaceImage;
        private int employeeId;

        public FormRegisterFace(int empId)
        {
            InitializeComponent();

            employeeId = empId;

            // Đường dẫn file cascade, bạn nên để trong thư mục dự án, không nên hardcode đường dẫn tuyệt đối
            _faceDetector = new CascadeClassifier(@"C:\Users\nguye\Desktop\HotelManagement\HotelManagement\HotelManagement\haarcascade_frontalface_default.xml");

            try
            {
                _capture = new VideoCapture(0); // 0 là webcam mặc định
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

            foreach (var face in faces)
            {
                image.Draw(face, new Bgr(Color.Red), 2);

                var faceImg = image.Copy(face).Resize(100, 100, Inter.Cubic);
                Bitmap faceBitmap = faceImg.ToBitmap();
                pictureBoxFace.Image = faceBitmap;

                _capturedFaceImage = faceBitmap;
            }

            pictureBoxCamera.Image = image.ToBitmap();
        }



        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (_capturedFaceImage == null)
            {
                MessageBox.Show("No face detected. Please try again.");
                return;
            }

            byte[] faceBytes = ImageToByteArray(_capturedFaceImage);

            UserRepository userRepo = new UserRepository();

            bool success = userRepo.UpdateFaceID(CurrentLogin.EmployeeID, faceBytes);

            if (success)
                MessageBox.Show("FaceID registered successfully!");
            else
                MessageBox.Show("Failed to save FaceID.");
        }

        public byte[] ImageToByteArray(Bitmap img)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
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
