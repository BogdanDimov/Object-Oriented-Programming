using System;

namespace OOP_Principles_Part1.Problem_1._School_classes
{
    public class Student : Human
    {
        public Student(string name, int classNumber, string comment) : base(name)
        {
            if (classNumber < 1)
            {
                throw new ArgumentOutOfRangeException($"{this.Name}'s class number must be equal to or greater than 1.");
            }

            this.ClassNumber = classNumber;
            this.TextComment = comment;
        }

        public int ClassNumber { get; }

        public string TextComment { get; }
    }
}
