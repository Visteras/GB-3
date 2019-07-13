namespace GB_3_3
{
    public class Triangle : IFigure
    {
        public float Square => 0.5f * Base * Height;

        private Triangle(float width, float height)
        {
            Base = width;
            Height = height;
        }

        public static IFigure Create()
        {
            return new Triangle(MyRand.Float(1, 10), MyRand.Float(1, 10));
        }

        public float Base { get; set; }
        public float Height { get; set; }

        public override string ToString() => $"[Triangle]\t Площадь: {Square}, Высота: {Height}, Основание: {Base}";
    }
}