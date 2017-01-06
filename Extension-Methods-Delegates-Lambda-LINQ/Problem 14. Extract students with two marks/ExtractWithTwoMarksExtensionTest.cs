namespace Extension_Methods_Delegates_Lambda_LINQ.Problem_14._Extract_students_with_two_marks
{
    using Student_Class;
    using System;

    public static class ExtractWithTwoMarksExtensionTest
    {
        public static void TestExtractWithTwoMarksExtension(Student[] students)
        {
            var studentsWithTwoTwos = students.ExtractWithTwoMarks2();

            Console.WriteLine("Testing extract students with exactly two marks (2)...");
            foreach (var student in studentsWithTwoTwos)
            {
                Console.WriteLine(student.FullName + " has exactly two marks (2).");
            }

            Console.WriteLine();
        }
    }
}
