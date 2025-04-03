using System;

namespace ColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Color color = new Color(80, 70, 200);
            Color color2 = new Color(200, 80, 70);

            Sphere sphere1 = new Sphere(color, 5);
            Sphere sphere2 = new Sphere(color2, 8);
            Console.WriteLine($"Sphere1: {sphere1.GetTimesThrown()}");
            Console.WriteLine($"Sphere2: {sphere2.GetTimesThrown()}");
            
            sphere1.Throw();
            sphere2.Throw();
            sphere2.Throw();
            sphere2.Throw();
            
            Console.WriteLine($"Sphere1: {sphere1.GetTimesThrown()}");
            Console.WriteLine($"Sphere2: {sphere2.GetTimesThrown()}");
            
            sphere2.Pop();
            sphere1.Throw();
            sphere1.Throw();
            sphere1.Throw();
            sphere2.Throw();
            sphere2.Throw();
            sphere2.Throw();
            
            Console.WriteLine($"Sphere1: {sphere1.GetTimesThrown()}");
            Console.WriteLine($"Sphere2: {sphere2.GetTimesThrown()}");
        }
    }
}
