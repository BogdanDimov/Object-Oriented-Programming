namespace OOP_Principles_Part2.Problem_1._Shapes
{
    //Define class Square and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method.

    public class Square : Shape
    {
        private double width;
        private double height;

        public Square(double side)
        {
            this.width = this.height = side;
        }

        public override double CalculateSurface()
        {
            return this.width * this.width;
        }
    }
}
