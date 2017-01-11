using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_Part1.Problem_3._Animal_hierarchy
{
    public class Frog : Animal, ISound
    {
        public Frog(int age, string name, Gender sex)
            : base(age, name, sex)
        {

        }

        public string MakeSound()
        {
            return "RRrribbit!";
        }
    }
}
