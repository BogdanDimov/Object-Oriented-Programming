namespace Extension_Methods_Delegates_Lambda_LINQ.Problem_3._First_before_last
{
    using System;
    using Student_Class;

    public static class FirstBeforeLastTest
    {
        public static void TestFirstBeforeLast(Student[] students)
        {
            var studentsWithFirstNameBeforeLastName = FirstBeforeLastMethod.ReturnStudentsWithFirstNameBeforeLastName(students);
            Console.WriteLine("Testing FirstBeforeLast method...");
            foreach (var student in studentsWithFirstNameBeforeLastName)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

            Console.WriteLine();
        }
    }
}
