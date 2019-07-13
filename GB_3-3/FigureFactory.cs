using System;

namespace GB_3_3
{
    public static class FigureFactory
    {
        public static IFigure GetFigure(FigureType type)
        {
            switch (type)
            {
                case FigureType.Circle:
                    return Circle.Create();
                case FigureType.Rectangle:
                    return Rectangle.Create();
                case FigureType.Triangle:
                    return Triangle.Create();
            }
            return UnknownFigure.Create();
        }

        public enum FigureType
        {
            Circle,
            Triangle,
            Rectangle,
            Square,
        }
    }
}