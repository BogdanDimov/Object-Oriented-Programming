namespace Extension_Methods_Delegates_Lambda_LINQ.Problem_13._Extract_students_by_marks
{
    using Student_Class;
    using System;
    using System.Collections.Generic;

    public static class ExtractByMarksTest
    {
        public static void TestExtractByMarks(Student[] students)
        {
            var studentsWithExcellentMark = ExtractByMarksMethod.ExtractByExcellentMark(students);
            var anonymousStudents = new List<dynamic>();
            Console.WriteLine("Extracting students with Excellent (6)...");
            foreach (var student in studentsWithExcellentMark)
            {
                anonymousStudents.Add(new { FullName = student.FirstName + " " + student.LastName, Marks = student.Marks });
            }

            foreach (var anonymous in anonymousStudents)
            {
                Console.WriteLine(anonymous.FullName + " has at least one Excellent(6).");
            }

            Console.WriteLine();
        }
    }
}
