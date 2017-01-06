namespace Extension_Methods_Delegates_Lambda_LINQ.Problem_5._Order_students
{
    using System;
    using System.Linq;
    using Student_Class;

    public static class OrderByThenByTest
    {
        public static void OrderByThenByLambda(Student[] students)
        {
            var sortedStudents = students.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);

            Console.WriteLine("Testing OrderBy() ThenBy() descending with Lambda...");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

            Console.WriteLine();
        }

        public static void OrderByThenByLINQ(Student[] students)
        {
            var sortedStudents =
                (from student in students
                 orderby student.FirstName descending, student.LastName descending
                 select student).ToArray();

            Console.WriteLine("Testing OrderBy() ThenBy() descending with LINQ...");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

            Console.WriteLine();
        }
    }
}
