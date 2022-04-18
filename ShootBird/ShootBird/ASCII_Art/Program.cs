using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Linq;

namespace ASCII_Art
{
    internal class Program
    {
        private const double WIDTH_OFFSET = 1.5;
        private const int MAX_WIDTH = 150;

        [STAThread]
        static void Main(string[] args)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Images | *.bmp; *.png; *.jpg; *.JPEG; "
            };

            Console.WriteLine("Жмакни Enter для старта...\n");

            while (true)
            {
                Console.ReadLine();

                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    continue;

                Console.Clear();

                var bitmap = new Bitmap(openFileDialog.FileName);
                bitmap = ResizeBitmap(bitmap);
                bitmap.ToGray();

                var converter = new BitmapToASCII(bitmap);
                var rows = converter.Convert();

                foreach(var row in rows)
                    Console.WriteLine(row);

                File.WriteAllLines("images.txt", rows.Select(r => new string(r)));


                Console.SetCursorPosition(0, 0);
            }
        }

        private static Bitmap ResizeBitmap(Bitmap bitmap)
        {
            var newHeight = bitmap.Height / WIDTH_OFFSET * MAX_WIDTH/ bitmap.Width;
            if(bitmap.Width > MAX_WIDTH || bitmap.Height > newHeight)
            {
                bitmap = new Bitmap(bitmap, new Size(MAX_WIDTH, (int)newHeight));              
            }
            return bitmap;
        }

    }
}
