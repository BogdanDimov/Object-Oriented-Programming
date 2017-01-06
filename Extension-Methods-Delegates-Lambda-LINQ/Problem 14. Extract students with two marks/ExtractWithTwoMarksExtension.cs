namespace Extension_Methods_Delegates_Lambda_LINQ.Problem_14._Extract_students_with_two_marks
{
    using Student_Class;
    using System.Linq;

    public static class ExtractWithTwoMarksExtension
    {
        public static dynamic ExtractWithTwoMarks2(this Student[] students)
        {
            var studentsWithTwoMarks2 = students
                .Where(x => x.Marks
                .FindAll(y => y == 2).Count == 2)
                .Select(x => new { FullName = x.FirstName + " " + x.LastName, Marks = x.Marks });

            return studentsWithTwoMarks2;
        }
    }
}
