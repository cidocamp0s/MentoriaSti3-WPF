using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MentoriaSti3.ViewModel
{
    public class UcPedidoViewModel : PropertyChange
    {

        private ObservableCollection<ClienteViewModel> _listaClientes;
        public ObservableCollection<ClienteViewModel> ListaClientes
        {
            get => _listaClientes;
            set
            {
                _listaClientes = value;
                OnPropertyChanged(nameof(ListaClientes));
            }
        }


        private ObservableCollection<ProdutoViewModel> _listaProdutos;
        public ObservableCollection<ProdutoViewModel> ListaProdutos
        {
            get => _listaProdutos;
            set
            {
                _listaProdutos = value;
                OnPropertyChanged(nameof(ListaProdutos));
            }
        }


        private ObservableCollection<string> _listaPagamentos;
        public ObservableCollection<string> ListaPagamentos
        {
            get => _listaPagamentos;
            set
            {
                _listaPagamentos= value;
                OnPropertyChanged(nameof(ListaPagamentos));
            }
        }


        private ObservableCollection<UcProdutoViewModel> _itensAdicionados;
        public ObservableCollection<UcProdutoViewModel> ItensAdicionados
        {
            get => _itensAdicionados;
            set
            {
                _itensAdicionados= value;
                OnPropertyChanged(nameof(ItensAdicionados));
            }
        }


        private decimal _quantidade;        
        public decimal Quantidade
        {
            get => _quantidade;
            set
            {
                _quantidade = value;
                OnPropertyChanged(nameof(Quantidade));
            }
        }

        private decimal _valorUnitario;
        public decimal ValorUnitario
        {
            get => _valorUnitario;
            set
            {
                _valorUnitario = value;
                OnPropertyChanged(nameof(ValorUnitario));
            }
        }


        private decimal _valorTotalPedido;
        public decimal ValorTotalPedido
        {
            get => _valorTotalPedido;
            set
            {
                _valorTotalPedido = value;
                OnPropertyChanged(nameof(ValorTotalPedido));
            }
        }




    }

}
