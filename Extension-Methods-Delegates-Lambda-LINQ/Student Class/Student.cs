namespace Extension_Methods_Delegates_Lambda_LINQ.Student_Class
{
    using System.Collections.Generic;

    public class Student
    {
        // Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks(a List), GroupNumber.
        public Student(string first, string last, int age, int fn, string tel, string email, List<int> marks, int groupNumber)
        {
            FirstName = first;
            LastName = last;
            Age = age;
            FN = fn;
            Tel = tel;
            Email = email;
            Marks = marks;
            GroupNumber = groupNumber;
        }

        public string FirstName { get; }

        public string LastName { get; }

        public int Age { get; }

        public int FN { get; }

        public string Tel { get; }

        public string Email { get; }

        public List<int> Marks { get; }

        public int GroupNumber { get; }
    }
}
