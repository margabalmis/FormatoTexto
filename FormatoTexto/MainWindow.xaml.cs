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

namespace FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            azulRadioButton.IsChecked = true;
        }



        private void negritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            formatoTextBox.FontWeight = FontWeights.Bold;

        }
        private void negritaCheckBox_UnChecked(object sender, RoutedEventArgs e)
        {

            formatoTextBox.FontWeight = FontWeights.Normal;

        }

        private void cursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {

            formatoTextBox.FontStyle = FontStyles.Italic;

        }
        private void cursivaCheckBox_UnChecked(object sender, RoutedEventArgs e)
        {

            formatoTextBox.FontStyle = FontStyles.Italic;

        }

        private void azulRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            formatoTextBox.Foreground = Brushes.Blue;
        }

        private void rojoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            formatoTextBox.Foreground = Brushes.Red;
        }

        private void verdeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            formatoTextBox.Foreground = Brushes.Green;
        }

        private void escrituraTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            formatoTextBox.Text = escrituraTextBox.Text;
        }
    }
}
