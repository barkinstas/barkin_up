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
    /// Логика взаимодействия для Window_qiwinumber.xaml
    /// </summary>
    public partial class Window_qiwinumber : Window
    {
        public Window_qiwinumber()
        {
            InitializeComponent();
        }

        private void TextBox_qiwinumber_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            TextBox_qiwinumber.Text += button.Content;
        }
    }
}
