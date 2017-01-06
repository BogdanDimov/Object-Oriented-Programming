namespace Extension_Methods_Delegates_Lambda_LINQ.Problem_4._Age_range
{
    using System.Linq;
    using Student_Class;

    public static class FindStudentsBetween18And24Method
    {
        public static Student[] FindStudentsBetween18And24(Student[] students)
        {
            var studentsBetween18And24 =
                                (from student in students
                                 where student.Age >= 18 && student.Age <= 24
                                 select student).ToArray();

            return studentsBetween18And24;
        }
    }
}
