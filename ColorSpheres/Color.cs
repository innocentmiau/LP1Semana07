using System;

namespace ColorSpheres
{
    public class Color
    {
        private readonly byte _red;
        public byte GetRed() => _red;
        
        private readonly byte _green;
        public byte GetGreen() => _green;
        
        private readonly byte _blue;
        public byte GetBlue() => _blue;
        
        private readonly byte _alpha;
        public byte GetAlpha() => _alpha;
        
        public Color(byte red, byte green, byte blue, byte alpha = 255)
        {
            _red = red;
            _green = green;
            _blue = blue;
            _alpha = alpha;
        }

        public byte GetGrey()
        {
            return Byte.Parse(((_red+_green+_blue)/3).ToString());
        }
    }
}