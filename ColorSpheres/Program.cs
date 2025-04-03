using System;

namespace ColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP1!");

            Color color = new Color(100, 100, 200);
            
            Console.WriteLine($"Grey: {color.GetGrey()}");
        }
    }
}
