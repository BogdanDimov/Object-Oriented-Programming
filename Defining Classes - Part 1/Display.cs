namespace Defining_Classes___Part_1
{
    public class Display
    {
        public int? NumberOfColors { get; set; }
        public double? Size { get; set; }

        public Display(int? numberOfColors = null, double? size = null)
        {
            NumberOfColors = numberOfColors;
            Size = size;
        }
    }
}
