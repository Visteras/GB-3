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
        
        public static IFigure GetFigure(string type)
        {
            switch (type)
            {
                case "Circle":
                    return Circle.Create();
                case "Rectangle":
                    return Rectangle.Create();
                case "Triangle":
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