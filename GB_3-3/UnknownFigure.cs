namespace GB_3_3
{
    public class UnknownFigure : IFigure
    {
        
        public float Square => 0f;
        private UnknownFigure(){}
        public static IFigure Create()
        {
            return new UnknownFigure();
        }

        public override string ToString() => $"[UnknownFigure]\t Неизвестная фигура";
        
    }
}