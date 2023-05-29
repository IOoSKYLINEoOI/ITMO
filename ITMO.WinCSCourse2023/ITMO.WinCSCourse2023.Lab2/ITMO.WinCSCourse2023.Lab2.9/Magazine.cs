using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClass
{
    class Magazine : Item, IPubs
    {
        private String volume;    // том
        private int number;        // номер
        private String title;       // название
        private int year;      // дата выпуска

        public bool IfSubs { get; set; } // подписка на журнал

        public Magazine(String volume, int number, String title, int year, long invNumber, bool taken)
            : base(invNumber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }


       public override void Return()    // операция "вернуть"
       {
            taken = true;
   
        }

        // реализация интерфейса

      

      public void Subs()
      {
            IfSubs = true;
            // действия при оформлении подписки на журнал
        }


       public override string ToString()
       {
           if (IfSubs)
           return "\n Журнал:\n Название: " + title + "\n Том: " + volume +
           "\n Номер: " + number + "\n Год выпуска: " + year + "\n Подписка оформлена" + "\n" + base.ToString();
           else
               return "\n Журнал:\n Название: " + title + "\nТом: " + volume +
           "\n Номер: " + number + "\n Год выпуска: " + year + "\n Подписка не оформлена" + "\n" + base.ToString(); ;
       }
    }
}
