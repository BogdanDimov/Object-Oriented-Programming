namespace OOP_Principles_Part2.Problem_1._Shapes
{
    //Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.

    public abstract class Shape
    {
        private double width;
        private double height;

        public abstract double CalculateSurface();
    }
}
