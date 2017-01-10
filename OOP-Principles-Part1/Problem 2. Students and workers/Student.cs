using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_Part1.Problem_2._Students_and_workers
{
    public class Student : Human
    {
        private double grade;

        public Student(string firstName, string lastName, double grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public double Grade
        {
            get
            {
                return this.grade;
            }

            private set
            {
                if (value < 1.00 || value > 6.00)
                {
                    throw new ArgumentNullException("Grade must be a value between 1.00 (Losh) and 6.00 (Otlichen).");
                }

                this.grade = value;
            }
        }
    }
}
