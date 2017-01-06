namespace Extension_Methods_Delegates_Lambda_LINQ.Problem_15._Extract_marks
{
    using Student_Class;
    using System;

    public static class ExtractMarksTest
    {
        public static void TestExtractMarks(Student[] students)
        {
            var allMarksFrom2006 = ExtractMarks.ExtractMarksFrom2006(students);
            Console.WriteLine("Extracting all marks of students from year 2006...");
            Console.WriteLine(String.Join(", ", allMarksFrom2006));
            Console.WriteLine();
        }
    }
}
