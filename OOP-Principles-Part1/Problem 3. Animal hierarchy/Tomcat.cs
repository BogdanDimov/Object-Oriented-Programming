using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_Part1.Problem_3._Animal_hierarchy
{
    public class Tomcat : Cat
    {
        public Tomcat(int age, string name, string breed = "mixed")
            : base(age, name, Gender.Male, breed)
        {

        }
    }
}
