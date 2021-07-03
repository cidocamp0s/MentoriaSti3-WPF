using MentoriaSti3.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interação lógica para UcProdutos.xam
    /// </summary>
    public partial class UcProdutos : UserControl
    {

        private UcProdutoViewModel UcProdutoVm = new UcProdutoViewModel();

        public UcProdutos()
        {
            InitializeComponent();

            DataContext = UcProdutoVm;

            UcProdutoVm.ProdutosAdicionados = new ObservableCollection<ProdutoViewModel>();

        }

        private void BtnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidarProduto()) return;


            if (UcProdutoVm.Alteracao)
            {
                AlterarProduto();
            }
            else
            {
                AdicionarProduto();
            }

            LimparCampos();
        }

        private void BtnAlterar_Click(object sender, RoutedEventArgs e)
        {
            var produto = (sender as Button).Tag as ProdutoViewModel;

            PreencherCampos(produto);           

        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);

        }

        private void PreencherCampos(ProdutoViewModel produto)
        {
            UcProdutoVm.Nome = produto.Nome;
            UcProdutoVm.Valor = produto.Valor;

            UcProdutoVm.Alteracao = true;
        }

        private void AdicionarProduto()
        {
            var novoProduto = new ProdutoViewModel
            {
                Nome = UcProdutoVm.Nome,
                Valor = UcProdutoVm.Valor
            };

            UcProdutoVm.ProdutosAdicionados.Add(novoProduto);

            UcProdutoVm.Alteracao = false;
        }

        private void AlterarProduto()
        {

        }

        private void LimparCampos()
        {

            UcProdutoVm.Nome = "";
            UcProdutoVm.Valor = 0;
            UcProdutoVm.Alteracao = false;
        }

        private bool ValidarProduto()
        {
            if (string.IsNullOrEmpty(UcProdutoVm.Nome))
            {
                MessageBox.Show("O campo Nome é obrigatório", "Atenção", MessageBoxButton.OK, MessageBoxImage.Information);

                return false;

            }

            return true;
        }

        private void BtnRemover_Click(object sender, RoutedEventArgs e)
        {

        }
    }




}
