using System.ComponentModel;

namespace FinalProject.ViewModels
{
    public class SuccessModel
    {
        public int StudentId { get; set; }

        public string FullName { get; set; }

        [DisplayName("Количество оценок")]
        public int CountGrade { get; set; }

        [DisplayName("Суммарный балл")]
        public int SumGrade { get; set; }
    }
}
