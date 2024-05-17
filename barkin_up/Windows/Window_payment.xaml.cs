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

namespace barkin_up
{
    /// <summary>
    /// Логика взаимодействия для Window_payment.xaml
    /// </summary>
    public partial class Window_payment : Window
    {
        public Window_payment()
        {
            InitializeComponent();
        }

        private void Button_cellular(object sender, RoutedEventArgs e)
        {
            Window_phonenumber x = new Window_phonenumber();
            x.Show();
            Close();
        }
    }
}
