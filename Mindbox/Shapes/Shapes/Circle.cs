namespace Shapes
{
    public class Circle : IGeometricShape
    {
        private double _radius = 0;
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double v
        {
            get { return v; }
            set { v = value; }
        }
        public double Radius
        {
            get => _radius;
            set
            {
                if (value <= 0)
                    throw new System.ArgumentException("The radius cannot take a non-positive value!");
                _radius = value; 
            }
        }
        public double Area
        {
            get => System.Math.PI * System.Math.Pow(_radius, 2);
        }
    }
}
