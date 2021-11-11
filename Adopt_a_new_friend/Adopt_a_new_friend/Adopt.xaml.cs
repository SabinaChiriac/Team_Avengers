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

namespace Adopt_a_new_friend
{
    /// <summary>
    /// Interaction logic for Adopt.xaml
    /// </summary>
    public partial class Adopt : Window
    {
        public Adopt()
        {
            InitializeComponent();
        }
        //Tip Animal
        private void watermarkedText_GotFocus(object sender, RoutedEventArgs e)
        {
            watermarkedText.Visibility = System.Windows.Visibility.Collapsed;
            tipAnimal.Visibility = System.Windows.Visibility.Visible;
            tipAnimal.Focus();
        }

        private void TipAnimal_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tipAnimal.Text))
            {
                tipAnimal.Visibility = System.Windows.Visibility.Collapsed;
                watermarkedText.Visibility = System.Windows.Visibility.Visible;
            }
        }

        //Varsta
        private void watermarkedText1_GotFocus(object sender, RoutedEventArgs e)
        {
            watermarkedText1.Visibility = System.Windows.Visibility.Collapsed;
            Varsta.Visibility = System.Windows.Visibility.Visible;
            Varsta.Focus();
        }

        private void Varsta_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Varsta.Text))
            {
                Varsta.Visibility = System.Windows.Visibility.Collapsed;
                watermarkedText1.Visibility = System.Windows.Visibility.Visible;
            }
        }

        //Rasa
        private void watermarkedText2_GotFocus(object sender, RoutedEventArgs e)
        {
            watermarkedText2.Visibility = System.Windows.Visibility.Collapsed;
            Rasa.Visibility = System.Windows.Visibility.Visible;
            Rasa.Focus();
        }

        private void Rasa_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Rasa.Text))
            {
                Rasa.Visibility = System.Windows.Visibility.Collapsed;
                watermarkedText2.Visibility = System.Windows.Visibility.Visible;
            }
        }

        //Descriere
        private void watermarkedText3_GotFocus(object sender, RoutedEventArgs e)
        {
            watermarkedText3.Visibility = System.Windows.Visibility.Collapsed;
            Descriere.Visibility = System.Windows.Visibility.Visible;
            Descriere.Focus();
        }

        private void Descriere_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Descriere.Text))
            {
                Descriere.Visibility = System.Windows.Visibility.Collapsed;
                watermarkedText3.Visibility = System.Windows.Visibility.Visible;
            }
        }

        //Numele
        private void watermarkedText4_GotFocus(object sender, RoutedEventArgs e)
        {
            watermarkedText4.Visibility = System.Windows.Visibility.Collapsed;
            Numele.Visibility = System.Windows.Visibility.Visible;
            Numele.Focus();
        }

        private void Numele_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Numele.Text))
            {
                Numele.Visibility = System.Windows.Visibility.Collapsed;
                watermarkedText4.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Formular trimis :)");
        }
    }
}
