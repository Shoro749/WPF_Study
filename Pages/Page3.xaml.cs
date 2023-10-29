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
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : UserControl
    {
        string userName;
        public Page3(string name)
        {
            InitializeComponent();
            userName = Name;
            user.Text = "Hello " + Name;
            tb_Disc.Text = "Iceland, a Nordic island nation, is defined by its\ndramatic landscape with volcanoes," +
            " geysers, hot\nsprings and lava fields. Most of the population lives\nin the capital, Reykjavik, which" +
            " runs on geothermal\npower and is home to the National and Saga\nmuseums, tracing Iceland's Viking history";
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new HomeScreen());
        }

        private void Next_Button(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new Page1(userName));
        }
    }
}
