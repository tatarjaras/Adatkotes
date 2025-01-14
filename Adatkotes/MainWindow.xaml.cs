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
        public MainWindow()
        {
            InitializeComponent();
            dgrFeladatok.ItemsSource = feladatok;
        }

        private void btnHozzaad_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}