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

namespace WpfApp1.Views
{
    /// <summary>
    /// Interaction logic for usCalc.xaml
    /// </summary>
    public partial class usCalc : UserControl
    {
        double acumula = 0;
        string operacao = "";
        public usCalc()
        {
            InitializeComponent();
        }

        private void sete_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "7";
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "0";
        }

        private void um_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "1";
        }

        private void dois_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "2";
        }

        private void tres_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "3";
        }

        private void quatro_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "4";
        }

        private void cinco_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "5";
        }

        private void seis_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "6";
        }

        private void oito_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "8";
        }

        private void nove_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "9";
        }

        private void soma_Click(object sender, RoutedEventArgs e)
        {

            if (operacao == "*" || operacao == "-" || operacao == "/")
            {
                operacao = "+";
            }
            else
            {
                acumula += double.Parse(display.Text);
                display.Text = "";
                operacao = "+";
            }

        }

        private void igual_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == "+")
            {
                acumula += double.Parse(display.Text);
                display.Text = acumula.ToString();
            }
            else if (operacao == "-")
            {
                acumula -= double.Parse(display.Text);
                display.Text = acumula.ToString();
            }
            else if (operacao == "*")
            {
                acumula *= double.Parse(display.Text);
                display.Text = acumula.ToString();
            }
            else if (operacao == "/")
            {
                if (double.Parse(display.Text) != 0)
                {
                    acumula /= double.Parse(display.Text);
                    display.Text = acumula.ToString();
                }
                else
                {
                    display.Text = "Dividindo por zero";
                }
            }
        }

        private void virgula_Click(object sender, RoutedEventArgs e)
        {
            display.Text += ",";
        }

        private void subtracao_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == "*" || operacao == "+" || operacao == "/")
            {
                operacao = "-";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operacao = "-";
            }
        }

        private void multiplicacao_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == "-" || operacao == "+" || operacao == "/")
            {
                operacao = "*";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operacao = "*";
            }
        }

        private void divisao_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == "*" || operacao == "+" || operacao == "-")
            {
                operacao = "/";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operacao = "/";
            }
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            display.Text = "";
            operacao = "";
        }
    }
}
