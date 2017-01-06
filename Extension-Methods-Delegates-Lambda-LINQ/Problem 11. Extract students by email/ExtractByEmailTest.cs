namespace Extension_Methods_Delegates_Lambda_LINQ.Problem_11._Extract_students_by_email
{
    using Student_Class;
    using System;

    public static class ExtractByEmailTest
    {
        public static void TestExtractByEmail(Student[] students, string domain)
        {
            var studentsWithMailFrom = ExtractByEmailMethod.ExtractByEmail(students, domain);
            Console.WriteLine("Testing ExtractByEmail()...");
            foreach (var student in studentsWithMailFrom)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " has email from abv.bg");
            }

            Console.WriteLine();
        }
    }
}
