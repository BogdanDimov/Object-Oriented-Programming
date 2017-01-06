namespace Extension_Methods_Delegates_Lambda_LINQ.Problem_19._Grouped_by_GroupName_extensions
{
    using System;
    using System.Linq;
    using Extension_Methods_Delegates_Lambda_LINQ.Student_Class;

    public static class GroupByExtensions
    {
        public static dynamic GroupByGroupNumber(this Student[] students)
        {
            var queryGroup =
               from student in students
               group student by student.GroupNumber into gr
               select new
               {
                   GroupNumber = gr.Key,
                   FirstName = gr.Select(x => x.FirstName)
               };

            return queryGroup;
        }

        public static void TestGroupByGroupNumber(Student[] students)
        {
            var groupedStudents = students.GroupByGroupNumber();

            Console.WriteLine("Testing student grouping with extensions...");
            foreach (var studentGroup in groupedStudents)
            {
                Console.WriteLine("Group #" + studentGroup.GroupNumber + " Students:\n" + String.Join("\n", studentGroup.FirstName));
            }

            Console.WriteLine();
        }
    }
}
