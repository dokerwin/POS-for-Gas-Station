using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_station.Util.Pdf
{    public class LogoImage
    {
        public string FileName;
        public int Width;
        public int Height;

        public LogoImage(string filename, int width, int height)
        {
            FileName = filename;
            Width = width;
            Height = height;
        }
    }
}
