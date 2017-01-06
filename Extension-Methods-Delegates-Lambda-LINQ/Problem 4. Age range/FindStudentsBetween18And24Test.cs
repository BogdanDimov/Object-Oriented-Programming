namespace Extension_Methods_Delegates_Lambda_LINQ.Problem_4._Age_range
{
    using System;
    using Student_Class;

    public static class FindStudentsBetween18And24Test
    {
        public static void TestFindStudentsBetween18And24(Student[] students)
        {
            var studentsBetween18And24 = FindStudentsBetween18And24Method.FindStudentsBetween18And24(students);
            Console.WriteLine("Testing FindStudentsBetween18And24()...");
            foreach (var student in studentsBetween18And24)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " Age: " + student.Age);
            }

            Console.WriteLine();
        }
    }
}
