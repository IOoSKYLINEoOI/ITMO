namespace FinalProject.Models
{
    public class Grade
    {
        public int GradeId { get; set; }

        //Дата оценки
        public DateTime DateOfGrade { get; set; }

        public int Score { get; set; }


        public int StudentId { get; set; }
        public Student Student { get; set; }


        public int TeacherId { get; set; }

        public Teacher Teacher { get; set; }

        public int SubjectID {  get; set; }
        public Subject Subject { get; set; }

    }
}
