namespace Extension_Methods_Delegates_Lambda_LINQ.Problem_10._Student_groups_extensions
{
    using Student_Class;
    using System.Linq;

    public static class StudentsGroupsExtensions
    {
        public static Student[] SelectByGroup(this Student[] students, int groupNumber)
        {
            var studentsFromGroup =
                (from student in students
                 where student.GroupNumber == groupNumber
                 orderby student.FirstName
                 select student).ToArray();

            return studentsFromGroup;
        }
    }
}
