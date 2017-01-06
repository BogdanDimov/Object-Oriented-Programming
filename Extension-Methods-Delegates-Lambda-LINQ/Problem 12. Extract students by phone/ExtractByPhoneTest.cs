namespace Extension_Methods_Delegates_Lambda_LINQ.Problem_12._Extract_students_by_phone
{
    using Student_Class;
    using System;

    public static class ExtractByPhoneTest
    {
        public static void TestExtractByPhone(Student[] students)
        {
            var studentsWithPhoneInSofia = ExtractByPhoneMethod.ExtractByPhone(students);
            Console.WriteLine("Testing ExtractByPhone()...");
            foreach (var student in studentsWithPhoneInSofia)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " has phone in Sofia.");
            }

            Console.WriteLine();
        }
    }
}
