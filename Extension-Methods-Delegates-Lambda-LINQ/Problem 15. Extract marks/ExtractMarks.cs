namespace Extension_Methods_Delegates_Lambda_LINQ.Problem_15._Extract_marks
{
    using Student_Class;
    using System.Collections.Generic;
    using System.Linq;

    public class ExtractMarks
    {
        public static List<int> ExtractMarksFrom2006(Student[] students)
        {
            var studentsFrom2006 = students
                .Where(student => student.FN.ToString().Substring(4, 2) == "06");
            var allMarksFrom2006 = new List<int>();
            foreach (var student in studentsFrom2006)
            {
                allMarksFrom2006.AddRange(student.Marks);
            }

            return allMarksFrom2006;
        }
    }
}
