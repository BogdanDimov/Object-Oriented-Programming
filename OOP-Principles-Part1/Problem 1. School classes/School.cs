using System;
using System.Linq;

namespace OOP_Principles_Part1.Problem_1._School_classes
{
    public class School
    {
        public School(Class[] classes)
        {
            if (classes.Count() < 1)
            {
                throw new ArgumentOutOfRangeException("School must contain at least one class of students.");
            }

            this.Classes = classes;
        }

        public Class[] Classes { get; }
    }
}
