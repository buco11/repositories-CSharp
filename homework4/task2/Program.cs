using System;

namespace task2
{
    public class FirstCourse
    {
        public string Name;
        public bool Pass;

        public bool Passed()
        {
            return Pass;
        }
    }

    public class SecondCourse
    {
        public string Name;
        public int Grade;

        public bool Passed()
        {
            if (Grade >= 6 && Grade <= 10) return true;
            else return false;
        }
    }

    public class Project
    {
        public FirstCourse course1;
        public FirstCourse course2;
        public SecondCourse course3;
        public SecondCourse course4;

        public bool Passed()
        {
            bool pass1 = course1.Passed();
            bool pass2 = course2.Passed();
            bool pass3 = course3.Passed();
            bool pass4 = course4.Passed();

            int counter = 0;

            if (pass1) counter++;
            if (pass2) counter++;
            if (pass3) counter++;
            if (pass4) counter++;

            if (counter >= 3) return true;

            else return false;

        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            //            Task 2

            //In this exercise you are asked to program three simple classes which keep track
            //of the grading of a sample student.
            //The classes are called FirstCourse, SecondCourse, and Project.
            //A FirstCourse encapsulates a course name and a registration of passed / not passed
            //for our sample student.
            //A SecondCourse encapsulates a course name and the grade of the student.
            //For grading we use the grades,
            //numerical grades 10, 9, 8, 7, 6, 5.You are also welcome use the enumeration.
            //The grade 6 is the lowest passing grade.
            //In both FirstCourse and SecondCourse you should write a method called Passed.
            //The method is supposed to return whether our sample student passes the course.
            //The class Project aggregates two FirstCourse courses and two SecondCourse courses.
            //You can assume that a project is passed if at least three out
            //of the four courses are passed.
            //Write a method Passed in class Project which implements this passing policy.
            //In Main method initialize 2 FirstCourse objects, 2 SecondCourse objects and 1 Project object.
            //Add both FirstCourse and both SecondCourse objects like a properties to Project object.
            //Call Project's object Passed method to see if the student passed.

            FirstCourse firstCourse1 = new FirstCourse();
            firstCourse1.Name = "C#";
            firstCourse1.Pass = false;

            FirstCourse firstCourse2 = new FirstCourse();
            firstCourse2.Name = "JS";
            firstCourse2.Pass = true;

            SecondCourse secondCourse1 = new SecondCourse();
            secondCourse1.Name = "Java";
            secondCourse1.Grade = 6;

            SecondCourse secondCourse2 = new SecondCourse();
            secondCourse2.Name = "C++";
            secondCourse2.Grade = 7;

            Project project = new Project();
            project.course1 = firstCourse1;
            project.course2 = firstCourse2;
            project.course3 = secondCourse1;
            project.course4 = secondCourse2;

            Console.WriteLine($"the student have passed C# {firstCourse1.Passed()}");
            Console.WriteLine($"the student have passed JS {firstCourse2.Passed()}");

            Console.WriteLine($"the student have passed Java {secondCourse1.Passed()}");
            Console.WriteLine($"the student have passed C++ {secondCourse2.Passed()}");

            bool result = project.Passed();
            if (result) Console.WriteLine("The student have passed the project");
            else Console.WriteLine("The student not passed");
        }
    }
}
