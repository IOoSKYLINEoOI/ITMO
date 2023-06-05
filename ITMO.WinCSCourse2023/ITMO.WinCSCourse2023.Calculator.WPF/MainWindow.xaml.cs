using Calculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ITMO.WinCSCourse2023.Calculator.WPF
{

    public partial class MainWindow : Window
    {
        private const string oneOut = "1";
        private const string twoOut = "2";
        private const string threeOut = "3";
        private const string fourOut = "4";
        private const string fiveOut = "5";
        private const string sixOut = "6";
        private const string sevenOut = "7";
        private const string eightOut = "8";
        private const string nineOut = "9";
        private const string zeroOut = "0";

        public MainWindow()
        {
            InitializeComponent();

            OutputDisplay.Text = "0";
        }

        private void KeyZero_Click(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(zeroOut);
        }

        private void KeyOne_Click(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(oneOut);
        }

        private void KeyTwo_Click(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(twoOut);
        }

        private void KeyThree_Click(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(threeOut);
        }

        private void KeyFour_Click(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(fourOut);
        }

        private void KeyFive_Click(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(fiveOut);
        }

        private void KeySix_Click(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(sixOut);
        }

        private void KeySeven_Click(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(sevenOut);
        }

        private void KeyEight_Click(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(eightOut);
        }

        private void KeyNine_Click(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(nineOut);
        }

        private void KeyPoint_Click(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcDecimal();
        }

        private void KeySign_Click(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcSign();
        }

        private void KeyPlus_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eAdd);
        }

        private void KeyMinus_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eSubtract);
        }

        private void KeyMultiply_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eMultiply);
        }

        private void KeyDivide_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eDivide);
        }

        private void KeyEqual_Click(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcEqual();
            CalcEngine.CalcReset();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void KeyClear_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcReset();
            OutputDisplay.Text = "0";
        }

        private void KeyXYZ_Click(object sender, RoutedEventArgs e)
        {

        }

        private void KeObr_Click(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcObr();
            CalcEngine.CalcReset();
        }

        private void KeyFact_Click(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcFact();
            CalcEngine.CalcReset();
        }

        private void KeySQRT_Click(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcSQRT();
            CalcEngine.CalcReset();
        }

        private void KeySQRT3_Click(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcSQRT3();
            CalcEngine.CalcReset();
        }

        private void KeySqare_Click(object sender, RoutedEventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcSqare();
            CalcEngine.CalcReset();
        }

        private void KeyXY_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eXY);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>


    }
}
