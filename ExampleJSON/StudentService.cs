using Models;
using System;

namespace Services
{
    class StudentService
    {
        private Student _studentValidade;
        public delegate bool ValidateHandler(Student student);

        public StudentService(Student student)
        {
            _studentValidade = student;
        }

        public bool ValidadeStudent(ValidateHandler validateStudent)
        {
            return validateStudent(_studentValidade);
        }

    }
}
