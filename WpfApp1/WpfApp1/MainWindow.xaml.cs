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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Item> Items { get; set; }

        public MainWindow()
        {
            Items = [
                new("AAAAAA", 1, "aaaaaa"),
                new("AAAAAA", 2, "bbbb"),
                new("AAAAAA", 3, "ccc"),
                new("AAAAAA", 4, "ddd"),
                new("AAAAAA", 5, "eeee"),
                new("BBBBB", 6, "ffff"),
                new("BBBBB", 7, "hhhh"),
                new("BBBBB", 8, "i"),
                new("BBBBB", 9, "jjjj"),
                new("BBBBB", 10, "kkkk"),
                new("BBBBB", 11, "lllllllll"),
                new("BBBBB", 12, "mmmmmmmmmm"),
                new("BBBBB", 13, "nnn"),
                new("BBBBB", 14, "ooooooooooo"),
                new("BBBBB", 15, "pp"),
                new("BBBBB", 16, "qqqqqqqqqq"),
                new("CCCCCCCC", 17, "rrrr"),
                new("CCCCCCCC", 18, "sss"),
                new("CCCCCCCC", 19, "ttt"),
                new("CCCCCCCC", 20, "uuuuuuuuuuuuuuu"),
                ];

            InitializeComponent();
        }
    }

    public record Item(string GroupName, int Identifier, string Name);
}