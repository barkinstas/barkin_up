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

namespace barkin_up
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

        private void Button_payment(object sender, RoutedEventArgs e)
        {
            Window_payment x = new Window_payment();
            x.Show();
            Close();
        }

        private void Button_qiwi(object sender, RoutedEventArgs e)
        {
            Window_qiwinumber x = new Window_qiwinumber();
            x.Show();
            Close();
        }

        private void Button_search(object sender, RoutedEventArgs e)
        {
            Window_search x = new Window_search();
            x.Show();
            Close();
        }

        
    }
}
