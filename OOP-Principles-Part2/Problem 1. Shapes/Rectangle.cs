namespace OOP_Principles_Part2.Problem_1._Shapes
{
    //Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure (height * width for rectangle and height * width/2 for triangle).

    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double CalculateSurface()
        {
            return this.height * this.width;
        }
    }
}
