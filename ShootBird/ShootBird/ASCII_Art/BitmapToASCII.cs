using System.Drawing;

namespace ASCII_Art
{
    internal class BitmapToASCII
    {
        private readonly char[] _charsTables = { '.', ',', ':', '+', '*', '?', '%', '$', '#', '@' };
        private readonly Bitmap _bitmap;
        public BitmapToASCII(Bitmap bitmap)
        {
            _bitmap = bitmap;
        }

        public char[][] Convert()
        {
            var result = new char[_bitmap.Height][];

            for(int i = 0; i < _bitmap.Height; i++)
            {
                result[i] = new char[_bitmap.Width];

                for(int j = 0; j < _bitmap.Width; j++)
                {
                    int mapIndex = (int)Map(_bitmap.GetPixel(j, i).R, 0, 255, 0, _charsTables.Length - 1);
                    result[i][j] = _charsTables[mapIndex];
                }
            }

            return result;
        }


        private float Map(float valueToMap, float startOne, float stopOne, float startTow, float stopTow)
        {
            return (valueToMap - startOne) / (stopOne - startOne) * (stopTow - startTow) + startTow;
        }
    }
}
