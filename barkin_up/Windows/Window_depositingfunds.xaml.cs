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
    public partial class Window_depositingfunds : Window
    {
        string[] names = { "Теле2", "Мегафон", "Билайн" };

        public Window_depositingfunds(string phone_number)
        {
            InitializeComponent();
            UpdateText();

            var Window_phonenumber = new Window_phonenumber();
            Window_phonenumber.TextChanged += Window_phonenumber_TextChanged;
            Text_phonenumber.Text = phone_number;
        }

        private void UpdateText()
        {
            Random rnd = new Random();
            int index = rnd.Next(names.Length);
            Text_Operator.Text = names[index];
        }

        private void Button_replenish(object sender, RoutedEventArgs e)
        {
            
        }

        private void Window_phonenumber_TextChanged(object sender, string newText)
        {
            Text_phonenumber.Text = newText;
        }

        private void Button_50(object sender, RoutedEventArgs e)
        {
            Text_Balance.Text = "Внесено 50 рублей";
            Replenish_Click.IsEnabled = true;
        }

        private void Button_1000(object sender, RoutedEventArgs e)
        {
            Text_Balance.Text = "Внесено 1000 рублей";
            Replenish_Click.IsEnabled = true;
        }

        private void Button_100(object sender, RoutedEventArgs e)
        {
            Text_Balance.Text = "Внесено 100 рублей";
            Replenish_Click.IsEnabled = true;
        }

        private void Button_2000(object sender, RoutedEventArgs e)
        {
            Text_Balance.Text = "Внесено 2000 рублей";
            Replenish_Click.IsEnabled = true;
        }

        private void Button_500(object sender, RoutedEventArgs e)
        {
            Text_Balance.Text = "Внесено 500 рублей";
            Replenish_Click.IsEnabled = true;
        }

        private void Button_5000(object sender, RoutedEventArgs e)
        {
            Text_Balance.Text = "Внесено 5000 рублей";
            Replenish_Click.IsEnabled = true;
        }

    }
}
