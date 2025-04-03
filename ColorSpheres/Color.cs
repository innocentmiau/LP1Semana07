using System;

namespace ColorSpheres
{
    public class Color
    {
        private byte _red;
        public byte GetRed() => _red;
        private byte _green;
        public byte GetGreen() => _green;
        private byte _blue;
        public byte GetBlue() => _blue;
        private byte _alpha;
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
            return Byte.Parse(((_red / 3) + (_green / 3) + (_blue / 3)).ToString());
        }
    }
}