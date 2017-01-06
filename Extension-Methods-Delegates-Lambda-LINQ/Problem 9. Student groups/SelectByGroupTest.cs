namespace Extension_Methods_Delegates_Lambda_LINQ.Problem_9._Student_groups
{
    using Student_Class;
    using System;

    public static class SelectByGroupTest
    {
        public static void TestSelectByGroup(Student[] students, int groupNumber)
        {
            var studentsFromGroup = SelectByGroupMethod.SelectByGroup(students, groupNumber);
            Console.WriteLine("Testing Group select for students...");
            foreach (var student in studentsFromGroup)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " is from group " + student.GroupNumber);
            }

            Console.WriteLine();
        }
    }
}
