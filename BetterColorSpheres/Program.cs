using System;

namespace BetterColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Color color = new Color(80, 70, 200);
            Color color2 = new Color(200, 80, 70);

            Sphere sphere1 = new Sphere(color, 5);
            string spc1 = $"{sphere1.color.red},{sphere1.color.green},{sphere1.color.blue}";
            Sphere sphere2 = new Sphere(color2, 8);
            string spc2 = $"{sphere2.color.red},{sphere2.color.green},{sphere2.color.blue}";
            Console.WriteLine($"Sphere1: {sphere1.GetTimesThrown()} ({spc1})");
            Console.WriteLine($"Sphere2: {sphere2.GetTimesThrown()} ({spc2})");
            
            
            sphere1.Throw();
            sphere2.Throw();
            sphere2.Throw();
            sphere2.Throw();
            
            Console.WriteLine($"Sphere1: {sphere1.GetTimesThrown()} ({spc1})");
            Console.WriteLine($"Sphere2: {sphere2.GetTimesThrown()} ({spc2})");
            
            sphere2.Pop();
            sphere1.Throw();
            sphere1.Throw();
            sphere1.Throw();
            sphere2.Throw();
            sphere2.Throw();
            sphere2.Throw();
            
            Console.WriteLine($"Sphere1: {sphere1.GetTimesThrown()} ({spc1})");
            Console.WriteLine($"Sphere2: {sphere2.GetTimesThrown()} ({spc2})");
        }
    }
}
