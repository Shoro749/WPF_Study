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
    /// Interaction logic for ErrorScreen.xaml
    /// </summary>
    public partial class ErrorScreen : UserControl
    {
        public ErrorScreen()
        {
            InitializeComponent();
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new HomeScreen());
        }
    }
}
