namespace TestLibrary
{
    using System;

    public interface IShape
    {
        double CalculateArea();
    }

    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Triangle : IShape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double CalculateArea()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool IsRightAngled()
        {
            double a2 = Math.Pow(A, 2);
            double b2 = Math.Pow(B, 2);
            double c2 = Math.Pow(C, 2);

            return a2 + b2 == c2 || a2 + c2 == b2 || b2 + c2 == a2;
        }
    }
}
