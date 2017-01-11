using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_Part1.Problem_3._Animal_hierarchy
{
    public class Kitten : Cat
    {
        public Kitten(int age, string name, string breed = "mixed")
            : base(age, name, Gender.Female, breed)
        {

        }
    }
}
