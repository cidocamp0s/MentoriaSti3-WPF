using MentoriaSti3.ViewModel;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

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
            AdicionarItem();
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
                new ClienteViewModel { Nome = "Cliente2" }
            };

            ucPedidoVm.ListaProdutos = new ObservableCollection<ProdutoViewModel>
            {
                new ProdutoViewModel{Nome="Produto 1", Valor=10},
                new ProdutoViewModel{Nome="Produto 2", Valor=20},

            };

            ucPedidoVm.ListaPagamentos = new ObservableCollection<String>
            {
                "Dinheiro",
                "Boleto",
                "Cartão de crédito",
                "Cartão de débiot",
                "Pix"

            };

            ucPedidoVm.Quantidade = 1;
            ucPedidoVm.ItensAdicionados = new ObservableCollection<UcPedidoItemViewModel>();


        }

        private void AdicionarItem()
        {
            var produtoSelecionado = cmbProduto.SelectedItem as ProdutoViewModel;

            var itemVm = new UcPedidoItemViewModel
            {
                Nome = produtoSelecionado.Nome,
                Quantidade = ucPedidoVm.Quantidade,
                ValorUnitario = ucPedidoVm.ValorUnitario,
                ValorTotalItem = ucPedidoVm.ValorUnitario * ucPedidoVm.Quantidade
            };

            ucPedidoVm.ItensAdicionados.Add(itemVm);

            ucPedidoVm.ValorTotalPedido = ucPedidoVm.ItensAdicionados.Sum(i => i.ValorTotalItem);
        }
    }
}
