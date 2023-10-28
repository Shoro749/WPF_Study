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
        int fails;
        bool gameStart = false;
        int indexWord;
        string textForButtons = "`1234567890-=!Tqwertyuiop[]|Casdfghjkl;'ESzxcvbnm,./LRWA QIU";
        string textForTraine = "hello";
        string[] textForTraine2 = { "hello", "hello world", "i love to program", "i bought liter of water", "i dont know where to put five stars for this app" };
        List<Button> buttons;
        List<char> buttonTextList;
        int activeButtonIndex = -1;
        public MainWindow()
        {
            InitializeComponent();
            buttons = new List<Button>();
            buttonTextList = textForButtons.Distinct().ToList();
            fails = 0;
            indexWord = 0;
            Fails.Text = "Fails: 0";
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
        private void CheckTrainText(char sign)
        {
            if (textForTraine == "" && indexWord == 4)
            {
                tbMain.Text = "You win";
            }
            else
            {
                if (textForTraine[0] == sign)
                {

                    textForTraine = textForTraine.Remove(0, 1);
                    if (textForTraine == "" && indexWord != 4)
                    {
                        indexWord++;
                        textForTraine = textForTraine2[indexWord];
                    }
                    tbMain.Text = textForTraine;
                    tbMain.UpdateLayout();
                }
                else
                {
                    fails += 1;
                    Fails.Text = Convert.ToString("Fails: " + fails);
                }
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            //if (gameStart == false)
            //{
            //    return;
            //}
            string textFind;
            textFind = (e.Key == Key.Space) ? "Space" : char.ToLower(e.Key.ToString()[0]).ToString();
            Button? b = buttons.Find(x => x.Content.ToString() == textFind.ToString());
            if (b is not null)
            {
                activeButtonIndex = buttons.IndexOf(b);
                b.Background = Brushes.LightGray;
            }
            CheckTrainText((e.Key == Key.Space) ? ' ' : textFind[0]);
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (activeButtonIndex != -1)
            {
                buttons[activeButtonIndex].Background = Brushes.Gray;
                activeButtonIndex = -1;
            }
        }

        private void StartButtonClick(object sender, RoutedEventArgs e)
        {
            gameStart = true;
            textForTraine = textForTraine2[indexWord];
            tbMain.Text = textForTraine;
        }

        private void StopButtonClick(object sender, RoutedEventArgs e)
        {
            gameStart = false;
        }
    }
}
