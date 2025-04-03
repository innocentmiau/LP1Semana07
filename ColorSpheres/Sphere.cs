namespace ColorSpheres
{
    public class Sphere
    {
        private Color _color;
        private float _radius;
        private int _shot;

        public Sphere(Color color, float radius)
        {
            _color = color;
            _radius = radius;
            _shot = 0;
        }

        public void Pop() => _radius = 0;

        public void Throw()
        {
            if (_radius > 0) _shot++;
        }

        public int GetTimesThrown() => _shot;
    }
}