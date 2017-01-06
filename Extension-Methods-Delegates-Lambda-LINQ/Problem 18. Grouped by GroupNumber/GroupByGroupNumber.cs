namespace Extension_Methods_Delegates_Lambda_LINQ.Problem_18._Grouped_by_GroupNumber
{
    using Student_Class;
    using System;
    using System.Linq;

    public class GroupByGroupNumber
    {
        public static dynamic GroupStudents(Student[] students)
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

        public static void TestGroupStudents(Student[] students)
        {
            var queryGroup = GroupStudents(students);
            Console.WriteLine("Testing student grouping with LINQ...");
            foreach (var studentGroup in queryGroup)
            {
                Console.WriteLine("Group #" + studentGroup.GroupNumber + " Students:\n" + String.Join("\n", studentGroup.FirstName));
            }

            Console.WriteLine();
        }
    }
}
