using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Runtime.CompilerServices;
using Microsoft.Data.Sqlite;

namespace barkin_up
{
    
    public partial class Window_search : Window
    {
        public Window_search()
        {
            InitializeComponent();
            LoadService("");
        }
        private Button GetServiceButton(string content)
        {
            Button btn = new Button() { Width = 300, Height = 100, HorizontalContentAlignment = HorizontalAlignment.Center, VerticalContentAlignment = VerticalAlignment.Center, Margin = new Thickness(130, 30, 0, 0), Content = GetTextBox(content) };
            return btn;
        }

        private void LoadService(string userSearch)
        {
            
            Panel.Children.Clear();

            
            using (var connection = new SqliteConnection("Data Source=barkin_up_bd.db"))
            {
                connection.Open();
                string sqlExpression = "SELECT * FROM Services";
                SqliteCommand command = new SqliteCommand(sqlExpression, connection);

                
                if (userSearch == string.Empty)
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows) 
                        {
                            while (reader.Read())   
                            {
                                Panel.Children.Add(GetServiceButton(reader.GetValue(0).ToString()));
                            }
                        }
                    }
                }


                else
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows) 
                        {
                            while (reader.Read())   
                            {
                                if (reader.GetValue(0).ToString().ToLower().Contains(userSearch.ToLower()))
                                {
                                    Panel.Children.Add(GetServiceButton(reader.GetValue(0).ToString()));
                                }

                            }
                        }
                    }
                }

            }
        }

        private void servicesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private TextBox GetTextBox(string text)
        {
            TextBox textBox = new TextBox() { Text = text, FontSize = 30, BorderThickness = new Thickness(0), IsReadOnly = true, Background = Brushes.Transparent, TextWrapping = TextWrapping.Wrap };
            return textBox;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox TextBox_SearchText = sender as TextBox;
            LoadService(TextBox_SearchText.Text);
        }
    }
}
