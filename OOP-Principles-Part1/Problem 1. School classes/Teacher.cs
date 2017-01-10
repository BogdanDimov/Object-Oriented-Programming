using System;
using System.Linq;

namespace OOP_Principles_Part1.Problem_1._School_classes
{
    public class Teacher : Human
    {
        public Teacher(string name, Discipline[] disciplines, string comment) : base(name)
        {
            if (disciplines.Count() < 1)
            {
                throw new ArgumentOutOfRangeException($"Teacher {this.Name} must teach at least one discipline.");
            }

            this.Disciplines = disciplines;
            this.TextComment = comment;
        }

        public Discipline[] Disciplines { get; }

        public string TextComment { get; }
    }
}
