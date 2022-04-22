using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;

namespace ASCII_Art
{
    internal class Program
    {
        private const double WIDTH_OFFSET = 2.3;
        private const int MAX_WIDTH = 200;
        public static bool x = false;

        [STAThread]
        static void Main(string[] args)
        {

            FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice); VideoCaptureDevice videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(Video_NewFrame);
            videoSource.Start();

            while (true)
            {
                if (x == true)
                {
                    videoSource.SignalToStop();
                    break;
                }
            }
            #region Для картинки
            //var openFileDialog = new OpenFileDialog
            //{
            //    Filter = "Images | *.bmp; *.png; *.jpg; *.JPEG; "
            //};


            //Console.WriteLine("Жмакни Enter для старта...\n");

            //while (true)
            //{

            //    Console.ReadLine();

            //    if (openFileDialog.ShowDialog() != DialogResult.OK)
            //        continue;

            //    Console.Clear();



            //    var bitmap = new Bitmap(openFileDialog.FileName);


            //    bitmap = ResizeBitmap(bitmap);
            //    bitmap.ToGray();

            //    var converter = new BitmapToASCII(bitmap);
            //    var rows = converter.Convert();

            //    foreach (var row in rows)
            //        Console.WriteLine(row);

            //    File.WriteAllLines("images.txt", rows.Select(r => new string(r)));


            //    Console.SetCursorPosition(0, 0);
            //}
            #endregion
        }

        private static Bitmap ResizeBitmap(Bitmap bitmap)
        {
            var newHeight = bitmap.Height / WIDTH_OFFSET * MAX_WIDTH / bitmap.Width;
            if (bitmap.Width > MAX_WIDTH || bitmap.Height > newHeight)
            {
                bitmap = new Bitmap(bitmap, new Size(MAX_WIDTH, (int)newHeight));
            }
            return bitmap;
        }

        static void Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            Bitmap bitmap = eventArgs.Frame;

            bitmap = ResizeBitmap(bitmap);
            bitmap.ToGray();

            var converter = new BitmapToASCII(bitmap);
            var rows = converter.Convert();

            foreach (var row in rows)
                Console.WriteLine(row);

            Console.SetCursorPosition(0, 0);
        }

    }

}
