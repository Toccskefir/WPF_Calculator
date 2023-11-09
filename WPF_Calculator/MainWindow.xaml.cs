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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Calculator
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

        private void buttonPlus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);

                labelNumber.Content = a + b;
                labelOperator.Content = "+";
            }
            catch (Exception)
            {
                MessageBox.Show("Hibás beviteli érték!");
            }
        }

        private void buttonMinus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);

                labelNumber.Content = a - b;
                labelOperator.Content = "-";
            }
            catch (Exception)
            {
                MessageBox.Show("Hibás beviteli érték!");
            }
        }

        private void buttonMultiplication_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);

                labelNumber.Content = a * b;
                labelOperator.Content = "*";
            }
            catch (Exception)
            {
                MessageBox.Show("Hibás beviteli érték!");
            }
        }

        private void buttonDivision_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = int.Parse(textBox1.Text);
                double b = int.Parse(textBox2.Text);

                labelNumber.Content = Math.Round(a / b, 2);
                labelOperator.Content = "/";
            }
            catch (Exception)
            {
                MessageBox.Show("Hibás beviteli érték!");
            }
        }

        private void buttonDivision2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = int.Parse(textBox1.Text);
                double b = int.Parse(textBox2.Text);

                labelNumber.Content = a % b;
                labelOperator.Content = "%";
            }
            catch (Exception)
            {
                MessageBox.Show("Hibás beviteli érték!");
            }
        }
    }
}
