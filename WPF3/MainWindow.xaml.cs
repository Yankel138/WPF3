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

namespace WPF3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(fontName);
            }
        }
        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            
            if (textBox != null)
            {
                double fontSize = Convert.ToDouble(((sender as ComboBox).SelectedItem as TextBox).Text);
                textBox.FontSize = fontSize;
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            string textColor = (sender as RadioButton).Name;

            if (textColor == "Черный")
                textBox.Foreground = new SolidColorBrush(Colors.Black);
            else if (textColor == "Красный")
                textBox.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void RadioButton_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }


    }
}
