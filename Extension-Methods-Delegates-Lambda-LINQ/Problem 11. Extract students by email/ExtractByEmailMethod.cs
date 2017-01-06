namespace Extension_Methods_Delegates_Lambda_LINQ.Problem_11._Extract_students_by_email
{
    using Student_Class;
    using System.Linq;

    public class ExtractByEmailMethod
    {
        public static Student[] ExtractByEmail(Student[] students, string domain)
        {
            var studentsWithMailFrom =
                (from student in students
                 where student.Email.Split('@')[1] == "abv.bg"
                 select student
                ).ToArray();

            return studentsWithMailFrom;
        }
    }
}
