using MentoriaSti3.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace MentoriaSti3.View.UserControls
{
    /// <summary>
    /// Interação lógica para UcPedido.xam
    /// </summary>
    public partial class UcPedido : UserControl
    {
        private UcPedidoViewModel ucPedidoVm = new UcPedidoViewModel();

        public UcPedido()
        {
            InitializeComponent();
            InicializarOperacao();
        }

        private void cmbProduto_DropDownClosed(object sender, EventArgs e)
        {
            if (sender is ComboBox cmb && cmb.SelectedItem is ProdutoViewModel produto)
            {
                ucPedidoVm.ValorUnitario = produto.Valor;
            }
        }

        private void BtnAdicionarItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnFinalizarPedido_Click(object sender, RoutedEventArgs e)
        {

        }

        private void InicializarOperacao()
        {
            DataContext = ucPedidoVm;

            ucPedidoVm.ListaClientes = new ObservableCollection<ClienteViewModel>
            {
                new ClienteViewModel{Nome="Cliente1"},
                new ClienteViewModel { Nome = "Cliente1" }
            };

            ucPedidoVm.ListaProdutos = new ObservableCollection<ProdutoViewModel>
            {
                new ProdutoViewModel{Nome="Produto 1", Valor=10},
                new ProdutoViewModel{Nome="Produto 2", Valor=20},

            };

            ucPedidoVm.ListaPagamentos = new  ObservableCollection<String>
            {
                "Dinheiro",
                "Boleto",
                "Cartão de crédito",
                "Cartão de débiot",
                "Pix"

            };

            ucPedidoVm.Quantidade = 1;
            ucPedidoVm.ItensAdicionados = new ObservableCollection<UcProdutoViewModel>();


        }
    }
}
