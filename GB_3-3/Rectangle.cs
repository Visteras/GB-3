namespace GB_3_3
{
    public class Rectangle : IFigure
    {
        public float Square => Width * Height;

        private Rectangle(float width, float height)
        {
            Width = width;
            Height = height;
        }

        public static IFigure Create()
        {
            return new Rectangle(MyRand.Float(1, 10), MyRand.Float(1, 10));
        }

        public float Width { get; set; }
        public float Height { get; set; }

        public override string ToString() => $"[Rectangle]\t Площадь: {Square}, Высота: {Height}, Ширина: {Width}";
    }
}