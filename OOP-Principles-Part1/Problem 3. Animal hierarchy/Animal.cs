using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_Part1.Problem_3._Animal_hierarchy
{
    public class Animal
    {
        private int age;
        private string name;
        private Gender sex;

        public Animal(int age, string name, Gender sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age must be a positive value.");
                }

                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Animal name must be specified.");
                }

                this.name = value;
            }
        }

        public Gender Sex
        {
            get
            {
                return this.sex;
            }

            private set
            {
                this.sex = value;
            }
        }
    }
}
