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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNavigate1_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Page1 p1 = new Page1(this);
            p1.Show();
        }

        private void btnNavigate2_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Page2 p2 = new Page2(this);
            p2.Show();
        }
    }
}
