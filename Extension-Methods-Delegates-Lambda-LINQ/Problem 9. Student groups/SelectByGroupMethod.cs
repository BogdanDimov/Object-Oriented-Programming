namespace Extension_Methods_Delegates_Lambda_LINQ.Problem_9._Student_groups
{
    using Student_Class;
    using System.Linq;

    public static class SelectByGroupMethod
    {
        public static Student[] SelectByGroup(Student[] students, int groupNumber)
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
