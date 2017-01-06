namespace Extension_Methods_Delegates_Lambda_LINQ.Problem_12._Extract_students_by_phone
{
    using Student_Class;
    using System.Linq;

    public class ExtractByPhoneMethod
    {
        public static Student[] ExtractByPhone(Student[] students)
        {
            var studentsWithPhoneInSofia =
                (from student in students
                 where student.Tel.Substring(0, 2) == "02"
                 select student).ToArray();

            return studentsWithPhoneInSofia;
        }
    }
}