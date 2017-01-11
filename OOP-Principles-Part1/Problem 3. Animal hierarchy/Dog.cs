using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_Part1.Problem_3._Animal_hierarchy
{
    public class Dog : Animal, ISound
    {
        public Dog(int age, string name, Gender sex, string breed = "mixed")
            : base(age, name, sex)
        {
            this.Breed = breed;
        }

        public string Breed { get; private set; }

        public string MakeSound()
        {
            return "Woof-woof!";
        }
    }
}
