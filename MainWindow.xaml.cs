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
using System.Diagnostics;

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

        private void GenerateButtonClick(object sender, RoutedEventArgs e)
        {
            //initialise all modules
            var modulesBuilder = new Module();
            var modules = modulesBuilder.generateModules();

            //initialise the shipbuilder
            ShipBuilder shipBuilder = new ShipBuilder();

            //create a ship list to contain all created ships
            List<Ship> ships = new List<Ship>();

            for (int i = 0; i < int.Parse(SprinterNumberTextBox.Text); i++)
            {
                ships.Add(shipBuilder.generate());    
            }

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // only accept numbers, and numbers between 0 and 5
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