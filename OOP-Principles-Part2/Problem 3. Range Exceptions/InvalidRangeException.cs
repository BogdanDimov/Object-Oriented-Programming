using System;

namespace OOP_Principles_Part2.Problem_3._Range_Exceptions
{
    // Define a class InvalidRangeException<T> that holds information about an error condition 
    // related to invalid range. It should hold error message and a range definition [start … end].
    public class InvalidRangeException<T> : Exception
    {
        private T rangeStart;
        private T rangeEnd;
        private const string errorMessage = "Entered value not in the range {0} - {1}";

        public InvalidRangeException(T rangeStart, T rangeEnd)
        {
            this.rangeStart = rangeStart;
            this.rangeEnd = rangeEnd;
        }

        public override string Message
        {
            get
            {
                return String.Format(errorMessage, rangeStart, rangeEnd);
            }
        }
    }
}
