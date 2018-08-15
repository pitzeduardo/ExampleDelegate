using Services;
using Models;
using System;

namespace ExampleJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Using Delegate -");
            var studentTest = MockStudentData();
            var studentClass = new StudentService(studentTest);

            Console.WriteLine("- Validate -");
            studentClass.ValidadeStudent(StudentValidate);

            Console.ReadLine();
        }

        public static bool StudentValidate(Student student)
        {
            Console.WriteLine("- Using StudentValidate -");

            if (string.IsNullOrEmpty(student.Name))
                return false;

            if (string.IsNullOrEmpty(student.Email))
                return false;

            if (!student.Email.Contains("@"))
                return false;

            return true;
        }

        #region Fake Data

        private static Student MockStudentData()
        {
            return new Student()
            {
                Name = "Eduardo Teste",
                Address = "Rua Teste",
                Email = "email@gmail.com",
                Age = 20
            };
        }

        #endregion 

    }
}