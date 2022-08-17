using System;

namespace Types
{
    class Student
    {
        public string Name { get; set; }

        public double TestMark { get; set; }

        public Student(string name, double testMark)
        {
            Name = name;
            TestMark = testMark;
        }
    }
    class Program
    {      
        public static bool isEqual<T>(T x, T y)
        {
            if (x.GetType() == typeof(string))
            {
                return x.ToString().ToLower().Equals(y.ToString().ToLower());
            }
            return x.Equals(y);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(isEqual("c", "C"));
        }

        //Overloading part of program
    }
}

