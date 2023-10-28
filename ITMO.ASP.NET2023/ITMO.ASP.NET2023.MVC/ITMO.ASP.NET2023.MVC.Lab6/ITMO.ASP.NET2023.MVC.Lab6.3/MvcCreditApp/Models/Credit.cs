using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcCreditApp.Models
{
    public class Credit
    {
        public virtual int CreditId { get; set; }

       
        [DisplayName("Тип")]
        [Required]
        public virtual string Head { get; set; }

        [DisplayName("Период")]
        public virtual int Period { get; set; }

        [DisplayName("Максимальная сумма")]
        [Required]
        public virtual int Sum { get; set; }

        [DisplayName("Процентная ставка")]
        public virtual int Procent { get; set; }
    }
}
