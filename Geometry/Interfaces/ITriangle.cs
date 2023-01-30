namespace Geometry.Interfaces
{
    internal interface ITriangle : IFigure
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        public double Perimeter { get; }
        public bool IsRectangular { get; }
    }
}
