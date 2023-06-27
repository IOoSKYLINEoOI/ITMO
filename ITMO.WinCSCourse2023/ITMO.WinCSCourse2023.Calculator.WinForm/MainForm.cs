using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimpleCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void KeyXYZ_Click(object sender, EventArgs e)
        {

            double a = Convert.ToDouble(KeyA.Text);
            double b = Convert.ToDouble(KeyB.Text);
            double c = Convert.ToDouble(KeyC.Text);

            double d = b * b - 4 * a * c;

            if (b == 0 && c == 0)
            {
                MessageBox.Show("Уравнение имеет один корень - 0");
            }
            else if (b == 0)
            {
                if (-c / a < 0)
                {
                    MessageBox.Show("Решений нет");
                }
                else
                {
                    double x1 = Math.Sqrt(-c / a);
                    double x2 = - Math.Sqrt(-c / a);
                    MessageBox.Show("Первый корень равен " + x1 + ". Второй корень равен " + x2 + ".");
                }
            }
            else if(c == 0)
            {
                double x1 = - b / a;
                MessageBox.Show("Первый корень равен " + 0 + ". Второй корень равен " + x1 + ".");
            }
            else if(a == 0)
            {
                MessageBox.Show($"Уравнение имеет один корень - {-c / a}") ;
            }
            else
            {
                if (d < 0)
                {
                    MessageBox.Show("Дискриминант меньше нуля. Корней нет.");
                }
                else if (d == 0)
                {
                    double x = (-b / (2 * a));
                    MessageBox.Show("Дискриминант равен нулю. Корень равен " + x + ".");
                }
                else
                {
                    double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                    double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                    MessageBox.Show("Дискриминант равен " + d + ". Первый корень равен " + x1 + ". Второй корень равен " + x2 + ".");
                }
            }
        }


    }
}
