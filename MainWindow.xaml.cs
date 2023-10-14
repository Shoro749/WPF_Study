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

namespace WPF_Study
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string textForButtons = "`1234567890-=!Tqwertyuiop[]|Casdfghjkl;'ESzxcvbnm,./LRWA QIU";
        string[] textForTraine = { "Hello", "Hello world!", "I love to program", "I bought 1.5 liters of water", "I don't know where to put 5 stars for this app" };
        List<Button> buttons;
        List<char> buttonTextList;
        int activeButtonIndex = -1;
        public MainWindow()
        {
            InitializeComponent();
            buttons = new List<Button>();
            buttonTextList = textForButtons.Distinct().ToList();
            tbMain.Text = textForTraine[0];
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            int i;
            for (i = 0; i < 14; i++)
            {
                Button button = new Button();
                button.Content = (buttonTextList[i] == '!')? "Backspace" : buttonTextList[i];
                button.Background = Brushes.Gray;
                button.BorderBrush = Brushes.Black;
                button.Width = (buttonTextList[i] == '!') ? 100 : 40;
                button.Height = 40;
                button.Margin = new Thickness(5);
                buttons.Add(button);
                stMain.Children.Add(button);
            }
            for (i = 14; i < 28; i++)
            {
                Button button = new Button();
                button.Content = (buttonTextList[i] == 'T') ? "Tab" : buttonTextList[i];
                button.Background = Brushes.Gray;
                button.BorderBrush = Brushes.Black;
                button.Width = (buttonTextList[i] == 'T') ? 80 : (buttonTextList[i] == '|') ? 60 : 40;
                button.Height = 40;
                button.Margin = new Thickness(5);
                buttons.Add(button);
                stMain2.Children.Add(button);
            }
            for (i = 28; i < 41; i++)
            {
                Button button = new Button();
                button.Content = (buttonTextList[i] == 'C') ? "Caps Lock" : (buttonTextList[i] == 'E') ? "Enter" : buttonTextList[i];
                button.Background = Brushes.Gray;
                button.BorderBrush = Brushes.Black;
                button.Width = (buttonTextList[i] == 'C') ? 95 : (buttonTextList[i] == 'E') ? 95 : 40;
                button.Height = 40;
                button.Margin = new Thickness(5);
                buttons.Add(button);
                stMain3.Children.Add(button);
            }
            for (i = 41; i < 53; i++)
            {
                Button button = new Button();
                button.Content = (buttonTextList[i] == 'S') ? "Shift" : (buttonTextList[i] == 'L') ? "Shift" : buttonTextList[i];
                button.Background = Brushes.Gray;
                button.BorderBrush = Brushes.Black;
                button.Width = (buttonTextList[i] == 'S') ? 120 : (buttonTextList[i] == 'L') ? 120 : 40;
                button.Height = 40;
                button.Margin = new Thickness(5);
                buttons.Add(button);
                stMain4.Children.Add(button);
            }
            for (i = 53; i < buttonTextList.Count; i++)
            {
                Button button = new Button();
                button.Content = (buttonTextList[i] == 'R') ? "Ctrl" : (buttonTextList[i] == 'W') ? "Win" : (buttonTextList[i] == 'A') ? "Alt"
                    : (buttonTextList[i] == ' ') ? "Space" : (buttonTextList[i] == 'Q') ? "Alt" : (buttonTextList[i] == 'I') ? "Win" :
                    (buttonTextList[i] == 'U') ? "Ctrl" : buttonTextList[i];
                button.Background = Brushes.Gray;
                button.BorderBrush = Brushes.Black;
                button.Width = (buttonTextList[i] == 'R') ? 60 : (buttonTextList[i] == 'W') ? 70 : (buttonTextList[i] == 'A') ? 70
                    : (buttonTextList[i] == ' ') ? 290 : (buttonTextList[i] == 'Q') ? 70 : (buttonTextList[i] == 'I') ? 70 :
                    (buttonTextList[i] == 'U') ? 60 : buttonTextList[i];
                button.Height = 40;
                button.Margin = new Thickness(5);
                buttons.Add(button);
                stMain5.Children.Add(button);
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            char symbol = Convert.ToChar(textForTraine[0]);
            var b = buttons.Find(x => x.Content.ToString() == symbol.ToString());

        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
