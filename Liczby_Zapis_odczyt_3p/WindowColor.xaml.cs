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

namespace Liczby_Zapis_odczyt_3p
{
    /// <summary>
    /// Logika interakcji dla klasy WindowColor.xaml
    /// </summary>
    public partial class WindowColor : Window
    {
        public byte R { get; set; } = 0;
        public byte G { get; set; } = 0;
        public byte B { get; set; } = 0;
        public WindowColor()
        {
            InitializeComponent();
        }

        private void Button_Click_ZatwierdzKolor(object sender, RoutedEventArgs e)
        {
            if(byte.TryParse(rTextBox.Text,out byte value))
            {
                R = value;
            }
            if (byte.TryParse(gTextBox.Text, out byte value2))
            {
                G = value2;
            }
            if (byte.TryParse(bTextBox.Text, out byte value3))
            {
                B = value3;
            }
            Close();
        }
    }
}
