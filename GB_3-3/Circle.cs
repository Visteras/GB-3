using System;

namespace GB_3_3
{
    public class Circle : IFigure
    {
        public float Square => Radius * Radius * (float) Math.PI;

        private Circle(float radius)
        {
            Radius = radius;
        }

        public static IFigure Create()
        {
            return new Circle(MyRand.Float(1, 10));
        }

        public float Radius { get; set; }

        public override string ToString() => $"[Circle]\t Площадь: {Square}, Радуис: {Radius}";
    }
}