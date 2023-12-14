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

namespace desktopowa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string haslo = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            haslo = "";
            int ilosc = Convert.ToInt32(ile.Text);
            int nr;
            string znaki = "abcdefghijklmnoprstuwxyvzq";
            Random los = new Random();
            

            if(wielkie.IsChecked == true)
            {
                string wielkie_znaki = "ABCDEFGHIJKLMNOPRSTWUXYZQ";


                nr = los.Next(0, 25);

                haslo += wielkie_znaki[nr];
                ilosc--;
            }

            if (cyfra.IsChecked == true)
            {
                string cyfry = "0123456789";


                nr = los.Next(0, 9);

                haslo += cyfry[nr];
                ilosc--;
            }

            //

            if (znak.IsChecked == true)
            {
                string tablica_znakow = "!@#$%^&*()_+-=";


                nr = los.Next(0, 13);

                haslo += tablica_znakow[nr];
                ilosc--;
            }



            for (int i = 0; i < ilosc; i++)
            {
               nr = los.Next(0,25);
                haslo += znaki[nr];

            }
            
            MessageBox.Show(haslo);

            
           // wynik.Text = haslo;
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string efekt_koncowy;

            efekt_koncowy = "Dane pracownika: " + imie.Text + " " + nazwisko.Text
                            + " " + stanowisko.Text + "Hasło: " + haslo;
             
            MessageBox.Show(efekt_koncowy);
        }
    }
}
