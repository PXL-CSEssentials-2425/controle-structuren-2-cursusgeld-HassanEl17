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

namespace ControleStructuren_2_Cursusgeld
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            //double jaar = double.Parse(jaarTextBox.Text);
            //double aantalLes = double.Parse(aantalUrenTextBox.Text);

            if (double.TryParse(jaarTextBox.Text, out double jaar) && double.TryParse(aantalUrenTextBox.Text, out double hour))
            {
                double uurGeld = 1.5;
                double totalGeld = hour * uurGeld;
                if ((jaar % 4 == 0) || (jaar % 400 == 0))
                {
                    totalGeld += uurGeld;
                    aantalTextBlock.Text = $"Is een schrikkeljaar";
                    yearTextBox.Text = totalGeld.ToString();
                }
                else
                {
                    aantalTextBlock.Text = $"Is geen schrikkeljaar";

                }
            }
        }

        private void testNumeriekButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(jaarTextBox.Text, out double jaar))
            {
                jaarTextblock.Text = $"Is Numeriek";
            }
            else
            {
                jaarTextblock.Text = $"Geef een correct jaartal!";
            }
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}