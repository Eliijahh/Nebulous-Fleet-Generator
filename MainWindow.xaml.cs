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

        void GenerateButtonClick(object sender, RoutedEventArgs e)
        {
            //generate all modules using the Module class
            var modulesBuilder = new Module();
            var modules = modulesBuilder.generateModules();

            //print all modules to the console
            foreach(var module in modules)
            {
                Console.WriteLine(module.getName());
            }

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