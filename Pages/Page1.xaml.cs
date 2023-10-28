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
using WPF_Study.Navigator;

namespace WPF_Study.Pages
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : UserControl
    {
        string userName;
        public Page1(string name)
        {
            InitializeComponent();
            userName = name;
            user.Text = "Hello " + userName;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new HomeScreen());
        }

        private void Next_Button(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new Page2(userName));
        }
    }
}
