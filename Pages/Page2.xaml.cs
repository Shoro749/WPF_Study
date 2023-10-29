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
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : UserControl
    {
        string userName;
        public Page2(string Name)
        {
            InitializeComponent();
            userName = Name;
            user.Text = "Hello " + Name;
            tb_Disc.Text = "Spain, a country on Europe's Iberian" +
                "Peninsula,\nincludes 17 autonomous regions with diverse\ngeography and cultures." +
                " Capital city Madrid is \nhome to the Royal Palace and Prado museum.\nhousing works by European masters\n";
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new HomeScreen());
        }

        private void Next_Button(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new Page3(userName));
        }
    }
}
