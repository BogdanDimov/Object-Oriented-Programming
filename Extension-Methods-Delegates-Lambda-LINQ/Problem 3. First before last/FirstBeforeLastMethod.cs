namespace Extension_Methods_Delegates_Lambda_LINQ.Problem_3._First_before_last
{
    using System.Linq;
    using Student_Class;

    public static class FirstBeforeLastMethod
    {
        public static Student[] ReturnStudentsWithFirstNameBeforeLastName(Student[] students)
        {
            var studentsWithFirstNameBeforeLastName =
                (from student in students
                 where string.Compare(student.FirstName, student.LastName) < 0
                 select student).ToArray();

            return studentsWithFirstNameBeforeLastName;
        }
    }
}
