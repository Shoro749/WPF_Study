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
        string str;
        double[] number = new double[10];
        string[] op = new string[10];

        void strUpdate(string str)
        {
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] != 0)
                {
                    if (str == "0")
                    {
                        str = "";
                    }
                    str += number[i];
                }
                else { break; }
                if (op[i] != null)
                {
                    str += op[i];
                }
                else { break; }
            }
            if (str == " ") 
            {
                str = "0";
            }
            else { input.Text = str; }
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            if (number[n] != 0)
            {
                number[n] = number[n] * 10;
            }
            strUpdate(str);
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
            strUpdate(str);
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
            strUpdate(str);
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
            strUpdate(str);
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
            strUpdate(str);
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
            strUpdate(str);
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
            strUpdate(str);
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
            strUpdate(str);
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
            strUpdate(str);
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
            strUpdate(str);
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            op[n] = "+";
            n++;
            strUpdate(str);
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            op[n] = "-";
            n++;
            strUpdate(str);
        }

        private void ButtonMult_Click(object sender, RoutedEventArgs e)
        {
            op[n] = "*";
            n++;
            strUpdate(str);
        }

        private void ButtonDiv_Click(object sender, RoutedEventArgs e)
        {
            op[n] = "/";
            n++;
            strUpdate(str);
        }

        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            n = 0;
            str = "0";
            for (int i = 0; i < number.Length; i++) 
            {
                number[i] = 0;
                op[i] = " ";
            }
            result.Text = "Result";
            input.Text = str;
        }

        private void ButtonPerc_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ця кнопка не працює!");
        }

        private void ButtonX_Click(object sender, RoutedEventArgs e)
        {
            if (number[0] != 0)
            {
                str = input.Text;
                string t = Convert.ToString(str[str.Length - 1]);
                if (t == "+" || t == "-" || t == "*" || t == "/")
                {
                    for (int i = 0; i < op.Length; i++)
                    {
                        if (op[i] == null)
                        {
                            op[i - 1] = null;
                            str = " ";
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < number.Length; i++)
                    {
                        if (number[i] == 0)
                        {
                            number[i - 1] = Math.Floor(number[i - 1] / 10);
                            str = " ";
                        }
                    }
                }
                strUpdate(str);
            }
        }

        private void ButtonDot_Click(object sender, RoutedEventArgs e)
        {
            str = input.Text;
            string t = Convert.ToString(str[str.Length - 1]);
            if (t == "+" || t == "-" || t == "*" || t == "/")
            {
                return;
            }
            MessageBox.Show("Вибачаюсь! Але ця кнопка не працює!");
        }

        private void ButtonIsEqual_Click(object sender, RoutedEventArgs e)
        {
            double res = 0;
            int index = 0;
            while (true)
            {
                
                if (number[index] == 0)
                {
                    break;
                }
                if (op[index] == "+")
                {
                    if (number[index+1] != 0)
                    {
                        if (res > 0)
                        {
                            res += number[index + 1];
                        }
                        else
                        {
                            res = number[index] + number[index + 1];
                        }
                    }
                }
                if (op[index] == "-")
                {
                    if (number[index + 1] != 0)
                    {
                        if (res > 0)
                        {
                            res -= number[index + 1];
                        }
                        else
                        {
                            res = number[index] - number[index + 1];
                        }
                    }
                }
                if (op[index] == "*")
                {
                    if (number[index + 1] != 0)
                    {
                        if (res > 0)
                        {
                            res *= number[index + 1];
                        }
                        else
                        {
                            res = number[index] * number[index + 1];
                        }
                    }
                }
                if (op[index] == "/")
                {
                    if (number[index + 1] != 0)
                    {
                        if (res > 0)
                        {
                            res /= number[index + 1];
                        }
                        else
                        {
                            if (number[index] == 0) { result.Text = "Error"; }
                            else { res = number[index] / number[index + 1]; }
                        }
                    }
                }
                index++;
            }
            result.Text = Convert.ToString(res);
        }

        private void ButtonCE_Click(object sender, RoutedEventArgs e)
        {
            str = input.Text;
            string t = Convert.ToString(str[str.Length - 1]);
            if (t == "+" || t == "-" || t == "*" || t == "/")
            {
                for (int i = 0; i < op.Length; i++)
                {
                    if (op[i] == null)
                    {
                        op[i - 1] = null;
                        str = "0";
                    }
                }
            }
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == 0)
                {
                    number[i - 1] = 0;
                    str = "0";
                }
            }
            strUpdate(str);
        }
    }
}
