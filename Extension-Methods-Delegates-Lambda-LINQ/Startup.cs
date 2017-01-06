namespace Extension_Methods_Delegates_Lambda_LINQ
{
    using System.Collections.Generic;
    using Student_Class;
    using Problem_1._StringBuilder.Substring;
    using Problem_2._IEnumerable_extensions;
    using Problem_3._First_before_last;
    using Problem_4._Age_range;
    using Problem_5._Order_students;
    using Problem_6._Divisible_by_7_and_3;
    using Problem_7._Timer;
    using Problem_9._Student_groups;
    using Problem_10._Student_groups_extensions;
    using Problem_11._Extract_students_by_email;
    using Problem_12._Extract_students_by_phone;
    using Problem_13._Extract_students_by_marks;
    using Problem_14._Extract_students_with_two_marks;
    using Problem_15._Extract_marks;
    using Problem_17._Longest_string;
    using Problem_18._Grouped_by_GroupNumber;
    using Problem_19._Grouped_by_GroupName_extensions;

    public class Startup
    {
        public static void Main()
        {
            StringBuilderExtensionsTest.TestStringBuilderExtensions();
            IEnumerableExtensionsTest.TestIEnumerableExtensions();

            Student[] students = new Student[] {
                                        new Student("Peshko", "Tapoto", 14, 123406123, "02123531", "peshko@tapaci.com", new List<int>() { 2, 3, 4, 5, 5, 4, 6, 6 }, 2),
                                        new Student("Koko", "Harpuncheto", 18, 123506124, "0870123532", "koko@abv.bg", new List<int>() { 5, 3, 4, 4, 4, 3, 3, 6 }, 2),
                                        new Student("Tsetsa", "Dashnata", 22, 132405134, "0870123544", "tsetska@abv.bg", new List<int>() { 6, 6, 6, 6, 5, 5, 5 }, 1),
                                        new Student("Tsvetelin", "Mazuta", 25, 1672404134, "0980126744", "tsetso@yahoo.com", new List<int>() { 2, 2, 5, 3, 3, 4, 4, 4 }, 1),
                                        new Student("Spiro", "Fasa", 24, 113407155, "02123544", "spiro@gmail.com", new List<int>() { 1, 2, 3, 2, 5, 5, 5, 5 }, 2),
                                        new Student("Bai", "Hoi", 99, 411406121, "0886532544", "baihoi@gmail.com", new List<int>() { 6, 6, 6, 6, 5, 5, 5 }, 1)
            };

            FirstBeforeLastTest.TestFirstBeforeLast(students);
            FindStudentsBetween18And24Test.TestFindStudentsBetween18And24(students);
            OrderByThenByTest.OrderByThenByLambda(students);
            OrderByThenByTest.OrderByThenByLINQ(students);
            NumbersDivisibleBy7And3Test.TestNumbersDivisibleBy7And3();
            TestTimer.TimerTest();
            SelectByGroupTest.TestSelectByGroup(students, 2);
            TestStudentsFromGroupsExtension.StudentsFromGroupsTest(students, 2);
            ExtractByEmailTest.TestExtractByEmail(students, "abv.bg");
            ExtractByPhoneTest.TestExtractByPhone(students);
            ExtractByMarksTest.TestExtractByMarks(students);
            ExtractWithTwoMarksExtensionTest.TestExtractWithTwoMarksExtension(students);
            ExtractMarksTest.TestExtractMarks(students);
            LongestString.TestLongestString();
            GroupByGroupNumber.TestGroupStudents(students);
            GroupByExtensions.TestGroupByGroupNumber(students);
        }
    }
}
