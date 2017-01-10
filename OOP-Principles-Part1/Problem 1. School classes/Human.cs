using System;

namespace OOP_Principles_Part1.Problem_1._School_classes
{
    public class Human
    {
        public Human(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name cannot be null or empty.");
            }

            this.Name = name;
        }

        public string Name { get; }
    }
}
