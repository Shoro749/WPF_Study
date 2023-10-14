using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using static System.Net.Mime.MediaTypeNames;

namespace WPF_Study
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            number[0] = 0;
            n = 0;
        }

        int n;
        string[] str = new string[10];
        double[] number = new double[10];
        string[] op = new string[10];

        void resultUpdate(string str)
        {
            result.Text = str;
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            if (number[n] != 0)
            {
                number[n] = number[n] * 10;
            }
            str[n] = Convert.ToString(number[0]);
            input.Text = str[n];
            resultUpdate(str[n]);
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (number[n] == 0)
            {
                number[n] = 1;
            }
            else
            {
                number[n] = number[n] * 10 + 1;
            }
            str[n] = Convert.ToString(number[0]);
            input.Text = str[n];
            resultUpdate(str[n]);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (number[n] == 0)
            {
                number[n] = 2;
            }
            else
            {
                number[n] = number[n] * 10 + 2;
            }
            str[n] = Convert.ToString(number[0]);
            input.Text = str[n];
            resultUpdate(str[n]);
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (number[n] == 0)
            {
                number[n] = 3;
            }
            else
            {
                number[n] = number[n] * 10 + 3;
            }
            str[n] = Convert.ToString(number[0]);
            input.Text = str[n];
            resultUpdate(str[n]);
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (number[n] == 0)
            {
                number[n] = 4;
            }
            else
            {
                number[n] = number[n] * 10 + 4;
            }
            str[n] = Convert.ToString(number[0]);
            input.Text = str[n];
            resultUpdate(str[n]);
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (number[n] == 0)
            {
                number[n] = 5;
            }
            else
            {
                number[n] = number[n] * 10 + 5;
            }
            str[n] = Convert.ToString(number[0]);
            input.Text = str[n];
            resultUpdate(str[n]);
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if (number[n] == 0)
            {
                number[n] = 6;
            }
            else
            {
                number[n] = number[n] * 10 + 6;
            }
            str[n] = Convert.ToString(number[0]);
            input.Text = str[n];
            resultUpdate(str[n]);
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (number[n] == 0)
            {
                number[n] = 7;
            }
            else
            {
                number[n] = number[n] * 10 + 7;
            }
            str[n] = Convert.ToString(number[0]);
            input.Text = str[n];
            resultUpdate(str[n]);
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if (number[n] == 0)
            {
                number[n] = 8;
            }
            else
            {
                number[n] = number[n] * 10 + 8;
            }
            str[n] = Convert.ToString(number[0]);
            input.Text = str[n];
            resultUpdate(str[n]);
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            if (number[n] == 0)
            {
                number[n] = 9;
            }
            else
            {
                number[n] = number[n] * 10 + 9;
            }
            str[n] = Convert.ToString(number[0]);
            input.Text = str[n];
            resultUpdate(str[n]);
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            op[n] = "+";
            n++;
            input.Text = str[n] + "+";
            resultUpdate(str[n]);
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonMult_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonDiv_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonPerc_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonX_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonDot_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonIsEqual_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
