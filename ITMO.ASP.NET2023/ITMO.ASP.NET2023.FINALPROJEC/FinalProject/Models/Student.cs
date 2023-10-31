using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Diagnostics;

namespace FinalProject.Models
{
    public class Student
    {
        // номер зачетной книжки 
        public virtual int StudentId { get; set; }

        [Required]
        [DisplayName("Имя")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Имя не может быть менее 2 и более 50 символов")]
        public virtual string FirstName { get; set; }

        [Required]
        [DisplayName("Фамилия")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Фамилия не может быть менее 2 и более 50 символов")]
        public virtual string LastName { get; set; }

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Отчество не может быть менее 2 и более 50 символов")]
        [DisplayName("Отчество")]
        public virtual string? SurName { get; set; }

        //[DisplayName("Дата рождения")]
        //[DataType(DataType.DateTime)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        //public virtual DateTime DateOfBirth { get; set; }

        public virtual ICollection<Grade> Grades { get; set; }

        [Display(Name = "ФИО")]
        public string FullName
        {
            get
            {
                return LastName + ' ' + FirstName + ' ' + SurName;
            }
        }

    }
}