using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_Part1.Problem_2._Students_and_workers
{
    public static class StudentsWorkersTest
    {
        private static Student[] stupidStudents =
        {
            new Student("Goshko", "Hubaveca", 5.50),
            new Student("Haralambi", "Lambov", 4.43),
            new Student("Maria", "Petrova", 6.00),
            new Student("Koko", "Jaitseto", 4.21),
            new Student("Stamatka", "Kifladjieva", 3.30),
            new Student("Teodora", "Kratunkova", 2.00),
            new Student("Hari", "Potarov", 1.00),
            new Student("Harmayana", "Tabakova", 3.70),
            new Student("Dambaldor", "Haritonski", 5.55),
            new Student("Pesho", "Telerikov", 4.90),
        };

        private static Worker[] cartoonWorkers =
        {
            new Worker("Kermit", "The Frog", 3000m, 12),
            new Worker("Cookie", "Monster", 1314m, 11),
            new Worker("Scooby", "Doo", 5000m, 9),
            new Worker("Tom", "The Cat", 0.0001m, 6),
            new Worker("Jerry", "The Mouse", 100m, 4),
            new Worker("Silvester", "The Pussycat", 125m, 10),
            new Worker("Tweety", "The Bird", 9935m, 8),
            new Worker("Spike", "The Dog", 1000000m, 3),
            new Worker("Porky", "The Pig", 4132m, 1),
            new Worker("Miss", "Piggy", 10m, 5),
        };

        public static void Test()
        {
            var sortedStudentsLINQ =
               (from s in stupidStudents
                orderby s.Grade ascending
                select s
               ).ToList();

            //var sortedStudentsLambda = stupidStudents.OrderBy(s => s.Grade).ToArray();

            foreach (var student in sortedStudentsLINQ)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} has grade: {student.Grade}");
            }

            Console.WriteLine();

            var sortedWorkersLINQ =
                (from w in cartoonWorkers
                 orderby w.MoneyPerHour() descending
                 select w
                ).ToList();

            foreach (var worker in sortedWorkersLINQ)
            {
                Console.WriteLine($"{worker.FirstName} {worker.LastName} earns money/hour: ${worker.MoneyPerHour():f2}");
            }

            Console.WriteLine();

            var merged = stupidStudents
                .Concat<Human>(cartoonWorkers)
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .ToList();

            foreach (var human in merged)
            {
                Console.WriteLine($"{human.FirstName} {human.LastName}");
            }
        }
    }
}
