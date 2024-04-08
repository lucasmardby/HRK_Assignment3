namespace HKR3_Task1
{
    internal class Sphere
    {
        private int radius;

        public Sphere()
        { 
        }
        public Sphere(int radius)
        {
            Radius = radius;
        }

        public int Radius
        {
            get { return radius; } 
            set 
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    radius = 0;
                }
            }
        }

        public double CalculateVolume(Sphere sphere)
        {
            return 4/3 * Math.PI * sphere.Radius;
        }
        public double CalculateSurfaceArea(Sphere sphere)
        {
            return 4 * Math.PI * Math.Pow(sphere.Radius, 2);
        }

    }
}
