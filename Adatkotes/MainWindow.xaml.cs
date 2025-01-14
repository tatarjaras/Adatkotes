using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Adatkotes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Feladat> feladatok = new List<Feladat>();
        Feladat current = new();
        public MainWindow()
        {
            InitializeComponent();
            dgrFeladatok.ItemsSource = feladatok;
            current.FeladatId = feladatok.Count+1;
            current.Leiras = "Új feladat";
            current.Hatarido = DateTime.Now;
            current.Kesz = false;
            current.Prioritas = 1;
            spCurrent.DataContext = current;
        }

        private void btnHozzaad_Click(object sender, RoutedEventArgs e)
        {


        }
    }
}