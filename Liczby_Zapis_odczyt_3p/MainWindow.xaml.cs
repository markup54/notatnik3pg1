using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Liczby_Zapis_odczyt_3p
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string NazwaPliku { get; set; } = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click_Zapisz(object sender, RoutedEventArgs e)
        {
            if(NazwaPliku == "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "pliki tekstowe | *.txt";
                if(saveFileDialog.ShowDialog()==true)
                {
                    //zapis do pliku
                    NazwaPliku = saveFileDialog.FileName;
                    File.WriteAllText(saveFileDialog.FileName, wpisaneTextBox.Text);
                }
            }
            else
            {
                File.WriteAllText(NazwaPliku, wpisaneTextBox.Text);
            }
            Title = NazwaPliku;
        }

        private void MenuItem_Click_Otworz(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog()==true)
            {
                NazwaPliku = openFileDialog.FileName;
                wpisaneTextBox.Text = File.ReadAllText(openFileDialog.FileName);
                Title = NazwaPliku;
            }
        }

        private void MenuItem_Click_Nowy(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(
                "Czy chcesz wcześniej coś zapisać?", 
                "Pytanie",
                MessageBoxButton.YesNoCancel, 
                MessageBoxImage.Question);
            if(result == MessageBoxResult.Yes)
            {
                MenuItem_Click_Zapisz(sender, e);
            }else if(result == MessageBoxResult.Cancel)
            {
                return;
            }
            NazwaPliku = "";
            wpisaneTextBox.Text = "";
            Title = "Notatnik";
        }

        private void TextChange_AktualizacjaTytułu(object sender, TextChangedEventArgs e)
        {
            if (Title.Contains("*") == false) {
                Title = "* " + Title;
            }
        }

        private void MenuItem_Click_Zamknij(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Click_CzerwonaCzcionka(object sender, RoutedEventArgs e)
        {
            if(wpisaneTextBox !=null)
            {
                wpisaneTextBox.Foreground = Brushes.Red;
            }
        }

        private void MenuItem_Click_Apka(object sender, RoutedEventArgs e)
        {
            WindowApka windowApka = new WindowApka();
            windowApka.Show();
        }

        private void MenuItem_Click_Autor(object sender, RoutedEventArgs e)
        {
            WindowAutor windowAutor = new WindowAutor();
            windowAutor.ShowDialog();
        }
    }
}
