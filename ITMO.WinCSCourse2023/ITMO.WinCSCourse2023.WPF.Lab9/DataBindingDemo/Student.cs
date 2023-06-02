using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using System.Globalization;

namespace DataBindingDemo
{
    public class Student
    {
        public string StudentName { get; set; }
        public bool IsEnrolled { get; set; }
    }

    public class StudentList : ObservableCollection<Student>
    {
    }


}
