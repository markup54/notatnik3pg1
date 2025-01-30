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
    /// Logika interakcji dla klasy WindowFont.xaml
    /// </summary>
    public partial class WindowFont : Window
    {
        public List<int> DostepneRozmiary { get; set; } = new List<int>();
        public WindowFont()
        {
            InitializeComponent();
            DataContext = this;
            for(int i = 6; i < 50; i += 2)
            {
                DostepneRozmiary.Add(i);
            }
        }
    }
}
