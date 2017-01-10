using System;

namespace OOP_Principles_Part1
{
    public class Discipline
    {
        public Discipline(string name, int numberOfLectures, int numberOfExcercises, string comment)
        {
            if (name.Length < 3)
            {
                throw new ArgumentException("Discipline's name must be at least 3 chars long.");
            }

            this.Name = name;

            if (numberOfLectures < 0)
            {
                throw new ArgumentOutOfRangeException($"The number of lectures in discipline {this.Name} cannot be negative.");
            }

            this.NumberOfLectures = numberOfLectures;

            if (numberOfExcercises < 0)
            {
                throw new ArgumentOutOfRangeException($"The number of exercises in discipline {this.Name} cannot be negative.");
            }

            this.NumberOfExercises = numberOfExcercises;
            this.TextComment = comment;
        }

        public string Name { get; }

        public int NumberOfLectures { get; }

        public int NumberOfExercises { get; }

        public string TextComment { get; }
    }
}
