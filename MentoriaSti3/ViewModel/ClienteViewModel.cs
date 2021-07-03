using System;
using System.Collections.Generic;
using System.Text;

namespace MentoriaSti3.ViewModel
{
    public class ClienteViewModel
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Cep { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }

    }
}
