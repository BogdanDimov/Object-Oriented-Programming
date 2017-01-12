namespace OOP_Principles_Part2.Problem_1._Shapes
{
    //Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure (height * width for rectangle and height * width/2 for triangle).

    public class Triangle : Shape
    {
        private double _base;
        private double height;

        public Triangle(double _base, double height)
        {
            this._base = _base;
            this.height = height;
        }

        public override double CalculateSurface()
        {
            return this.height * this._base / 2;
        }
    }
}
