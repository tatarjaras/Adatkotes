using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
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
        static List<Feladat> feladatok = new List<Feladat>();
        static Feladat current = new();
        public MainWindow()
        {
            InitializeComponent();
            dgrFeladatok.ItemsSource = feladatok;
            SetNewCurrent(); 
            spCurrent.DataContext = current;
            
        }

        private void btnHozzaad_Click(object sender, RoutedEventArgs e)
        {
            feladatok.Add(current);
            current = new();
            SetNewCurrent();
            spCurrent.DataContext= current;
            dgrFeladatok.Items.Refresh();

        }
        private static void SetNewCurrent()
        {
            current.FeladatId = feladatok.Count + 1;
            current.Leiras = "Új feladat";
            current.Hatarido = DateTime.Now;
            current.Kesz = false;
            current.Prioritas = 1;
           
        }
 
        private void mnuBeolvasás_Click(object sender, RoutedEventArgs e)
        {
            string json = File.ReadAllText("feladatok.json");
            feladatok = JsonSerializer.Deserialize<List<Feladat>>(json);

        }

        private void mnuMentés_Click(object sender, RoutedEventArgs e)
        {
            var options1 = new JsonSerializerOptions
            {
                Encoder=JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndented = true
            };
            string json = JsonSerializer.Serialize(feladatok,options1);

            File.WriteAllText("feladatok.json", json);
        }
    }
}