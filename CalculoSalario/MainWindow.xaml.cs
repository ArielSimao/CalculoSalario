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

namespace CalculoSalario {
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window {

        public List<Funcionario> listaFunc = new List<Funcionario>();
        private double valor1 = 0.0;
        private double valor2 = 0.0;

        public MainWindow() {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e) {
            string nome = txtFuncionario.Text;
            double salarioBruto = double.Parse(txtSalario.Text);

            Funcionario f = new Funcionario(nome, salarioBruto);
            listaFunc.Add(f);

            valor1 = salarioBruto;
            if(rbComissao.IsChecked == true) {
                valor1 += (valor1 * 1) / 100;
                txtSalarioFixo.Text = valor1.ToString();
            }
            if(rbCusto.IsChecked == true) {
                valor1 += 200;
                txtSalarioFixo.Text = valor1.ToString();
            }
            if(cbVale.IsChecked == true) {
                valor1 += 200;
                txtSalarioFixo.Text = valor1.ToString();
            }
            if(cbImposto.IsChecked == true) {
                valor1 = (valor1 * 3) / 100;
                txtSalarioFixo.Text = valor1.ToString();
            }

            dataGrid.ItemsSource = listaFunc.OrderBy(user => user.Nome);

        }

        private void button1_Click(object sender, RoutedEventArgs e) {
            Close();
        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e) {
            txtSalarioFixo.Text = "";
        }
    }
}
