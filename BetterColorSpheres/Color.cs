using System;

namespace BetterColorSpheres
{
    public class Color
    {

        public byte red { get; }
        public byte green { get; }
        public byte blue { get; }
        public byte alpha { get; }

        public Color(byte red, byte green, byte blue) : this(red, green, blue, 255) {}
        
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public byte GetGrey()
        {
            return Byte.Parse(((red+green+blue)/3).ToString());
        }
        
    }
}