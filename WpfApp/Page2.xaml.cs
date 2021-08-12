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
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Window
    {
        public Page2(Window mainPage)
        {
            InitializeComponent();
            MainPage = mainPage;
        }

        private void btnNavigateMain_Click(object sender, RoutedEventArgs e)
        {
            MainPage.Show();
            this.Close();
        }

        private Window MainPage { get; set; }
    }
}
