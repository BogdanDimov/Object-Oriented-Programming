using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_Part1.Problem_3._Animal_hierarchy
{
    public static class AnimalsTest
    {
        public static void Test()
        {
            Animal[] cats =
            {
                new Tomcat(5,"Koko"),
                new Cat(6,"Coko", Gender.Male),
                new Kitten(10, "Missy")
            };

            Animal[] frogs =
            {
                new Frog(1,"Jabko", Gender.Male),
                new Frog(2,"Kikirica", Gender.Female),
                new Frog(4, "Prince", Gender.Male)
            };

            Animal[] dogs =
            {
                new Dog(12,"Jack", Gender.Male),
                new Dog(15,"Rex", Gender.Male),
                new Dog(8, "Shely", Gender.Female)
            };

            var avgAgeCats = cats.Average(x => x.Age);
            var avgAgeDogs = dogs.Average(x => x.Age);
            var avgAgeFrogs = frogs.Average(x => x.Age);

            Console.WriteLine($"Average age of cats: {avgAgeCats:f2}");
            Console.WriteLine($"Average age of dogs: {avgAgeDogs:f2}");
            Console.WriteLine($"Average age of frogs: {avgAgeFrogs:f2}");
        }
    }
}
