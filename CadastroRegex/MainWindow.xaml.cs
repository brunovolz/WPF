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
using System.Text.RegularExpressions;

namespace CadastroRegex
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (CadName.Text == "" || CadNumber.Text == "" || CadEmail.Text == "")
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                CadName.Focus();
                return;
            }                                            //+55(47)99708-2113
            if (!Regex.Match(CadNumber.Text, @"\(?\d{2}\)?-? *\d{5}-? *-?\d{4}").Success)
            {
                MessageBox.Show("Número inválido", "Mensagem", MessageBoxButton.OK, MessageBoxImage.Error);
                CadNumber.Focus();
                return; 
            }
            if (!Regex.Match(CadEmail.Text, @"^[\\w!#$%&'*+/=?`{|}~^-]+(?:\\.[\\w!#$%&'*+/=?`{|}~^-]+)*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$").Success)
            {
                MessageBox.Show("E-mail inválido", "Mensagem", MessageBoxButton.OK, MessageBoxImage.Error);
                CadEmail.Focus();
                return;
            }

            this.Hide(); // hide main window while MessageBox displays  
            MessageBox.Show("Thank You!", "Information Correct", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
