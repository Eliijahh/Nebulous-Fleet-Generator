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

namespace NebulousFleetGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //create a class that have a name string, a location string, and three Size 1, 2, 3 int variables
        public class Slot
        {
            public string Name { get; set; }
            public string Location { get; set; }
            public int Size1 { get; set; }
            public int Size2 { get; set; }
            public int Size3 { get; set; }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // only accept numbers
            if (!int.TryParse(((TextBox)sender).Text, out _))
            {
                ((TextBox)sender).Text = "";
            } else if (int.Parse(SprinterNumberTextBox.Text) > 5)
            {
                SprinterNumberTextBox.Text = "5";
            }
            else if (int.Parse(SprinterNumberTextBox.Text) < 0)
            {
                SprinterNumberTextBox.Text = "0";
            }
        }
    }
}