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
    /// Логика взаимодействия для Window_phonenumber.xaml
    /// </summary>
    public partial class Window_phonenumber : Window
    {
        public event EventHandler<string> TextChanged;

        public Window_phonenumber()
        {
            InitializeComponent();
        }

        private void button_click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            TextBox_phonenumber.Text += button.Content;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox_phonenumber.Text.Length > 3)
            {
                TextBox_phonenumber.Text = TextBox_phonenumber.Text.Remove(TextBox_phonenumber.Text.Length - 1);
            }
        }

        private void Button_back(object sender, RoutedEventArgs e)
        {
            Window_payment x = new Window_payment();
            x.Show();
            Close();
        }

        private void Button_Next(object sender, RoutedEventArgs e)
        {
            if (TextBox_phonenumber.Text.Length == 14)
            {
                Window_depositingfunds x = new Window_depositingfunds(TextBox_phonenumber.Text);
                x.Show();
                Close();
            }
        }

        private void Button_Delete(object sender, RoutedEventArgs e)
        {
            if (TextBox_phonenumber.Text.Length > 3)
            {
                TextBox_phonenumber.Text = TextBox_phonenumber.Text.Remove(TextBox_phonenumber.Text.Length - 1);
            }
        }

        private void TextBox_phonenumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextChanged?.Invoke(this, TextBox_phonenumber.Text);
        }
    }
}
