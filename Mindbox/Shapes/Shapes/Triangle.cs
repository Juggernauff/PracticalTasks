namespace Shapes
{
    public class Triangle : IGeometricShape
    {
        private double _sideA = 0;
        private double _sideB = 0;
        private double _sideC = 0;
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        public double SideA
        {
            get => _sideA;
            set
            {
                if (value <= 0)
                    throw new System.ArgumentException("The side of the triangle cannot take a non-positive value!");
                _sideA = value;
            }
        }
        public double SideB
        {
            get => _sideB;
            set
            {
                if (value <= 0)
                    throw new System.ArgumentException("The side of the triangle cannot take a non-positive value!");
                _sideB = value;
            }
        }
        public double SideC
        {
            get => _sideC;
            set
            {
                if (value <= 0)
                    throw new System.ArgumentException("The side of the triangle cannot take a non-positive value!");
                _sideC = value;
            }
        }
        public double Area
        {
            get
            {
                var p = (_sideA + _sideB + _sideC) / 2;
                return System.Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
            }
        }
    }
}
