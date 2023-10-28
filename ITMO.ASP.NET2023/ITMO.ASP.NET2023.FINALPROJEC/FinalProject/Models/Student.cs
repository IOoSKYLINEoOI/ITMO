using System.Numerics;

namespace FinalProject.Models
{
    public class Student
    {
        // номер зачетной книжки 
        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string  SurName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int? GroupId { get; set; }

        // Список предметов
        public IEnumerable<Subject> Subjects { get; set; }

        //Список оценок

        public IEnumerable<Grade> Grades { get; set; }
    }
}
