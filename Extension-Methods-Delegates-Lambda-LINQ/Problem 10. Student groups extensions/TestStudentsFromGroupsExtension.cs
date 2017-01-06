namespace Extension_Methods_Delegates_Lambda_LINQ.Problem_10._Student_groups_extensions
{
    using Student_Class;
    using System;

    public static class TestStudentsFromGroupsExtension
    {
        public static void StudentsFromGroupsTest(Student[] students, int groupNumber)
        {
            var studentsFromGroup = students.SelectByGroup(groupNumber);
            Console.WriteLine("Testing Student groups extensions...");
            foreach (var student in studentsFromGroup)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " is from group " + student.GroupNumber);
            }

            Console.WriteLine();
        }
    }
}
