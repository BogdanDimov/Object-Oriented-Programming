namespace Extension_Methods_Delegates_Lambda_LINQ.Problem_13._Extract_students_by_marks
{
    using Student_Class;
    using System.Linq;

    public class ExtractByMarksMethod
    {
        public static Student[] ExtractByExcellentMark(Student[] students)
        {
            var studentsWithExcellentMark =
                (from student in students
                 where student.Marks.Contains(6)
                 select student).ToArray();

            return studentsWithExcellentMark;
        }
    }
}