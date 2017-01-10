using System;
using System.Linq;

namespace OOP_Principles_Part1.Problem_1._School_classes
{
    public class Class
    {
        public Class(string id, Student[] students, Teacher[] teachers, string comment)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException("You must specify class id.");
            }

            this.Id = id;

            if (students.Count() < 1)
            {
                throw new ArgumentOutOfRangeException($"Class {this.Id} must contain at least one student.");
            }

            this.Students = students;

            if (teachers.Count() < 1)
            {
                throw new ArgumentOutOfRangeException($"Class {this.Id} must contain at least one teacher.");
            }

            this.Teachers = teachers;
            this.TextComment = comment;
        }

        public string Id { get; }

        public Student[] Students { get; }

        public Teacher[] Teachers { get; }

        public string TextComment { get; }
    }
}
