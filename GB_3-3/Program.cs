using System;
using System.Diagnostics;

namespace GB_3_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IFigure[] figures = new[]
            {
                FigureFactory.GetFigure(FigureFactory.FigureType.Circle),
                FigureFactory.GetFigure(FigureFactory.FigureType.Rectangle),
                FigureFactory.GetFigure(FigureFactory.FigureType.Circle),
                FigureFactory.GetFigure(FigureFactory.FigureType.Triangle),
                FigureFactory.GetFigure(FigureFactory.FigureType.Circle),
                FigureFactory.GetFigure(FigureFactory.FigureType.Rectangle),
                FigureFactory.GetFigure(FigureFactory.FigureType.Triangle),
                FigureFactory.GetFigure(FigureFactory.FigureType.Triangle),
                FigureFactory.GetFigure(FigureFactory.FigureType.Circle),
                FigureFactory.GetFigure(FigureFactory.FigureType.Square),
            };

            foreach (var figure in figures)
            {
                Console.WriteLine(figure);
            }
        }
    }
}