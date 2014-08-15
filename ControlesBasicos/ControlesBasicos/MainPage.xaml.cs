using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace ControlesBasicos
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, RoutedEventArgs e)
        {
            if (txtNome.Text == "Fatec" && 
                pwsSenha.Password.ToString() == "12345")
            {
                MessageBox.Show("Acessado");
                NavigationService.Navigate(
                    new Uri("/Acesso.xaml", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("Acesso negado!");
            }
        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            txtNome.Text = String.Empty;
            pwsSenha.Password = String.Empty;
        }
    }
}