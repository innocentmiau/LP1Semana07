namespace BetterColorSpheres
{
    public class Sphere
    {

        public Color color { get;  }
        private float radius { get; set;  }
        private int _shot { get; set; } = 0;
        
        public Sphere(Color color, float radius)
        {
            this.color = color;
            this.radius = radius;
        }

        public void Pop() => radius = 0;

        public void Throw()
        {
            if (radius > 0) _shot++;
        }

        public int GetTimesThrown() => _shot;
    }
}