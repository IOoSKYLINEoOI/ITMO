using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FinalProject.Models;

namespace FinalProject.Models
{
    public class Grade
    {
        public virtual int GradeId { get; set; }

        //[DisplayName("Дата выставления оценки")]
        //[DataType(DataType.DateTime)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        //public virtual DateTime DateOfGrade { get; set; }

        [DisplayName("Оценка")]
        [Range(0, 5)]
        public virtual int Score { get; set; }

        public virtual int StudentId { get; set; }
        public Student Student { get; set; }
    }
}