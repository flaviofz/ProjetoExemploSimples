using System;
using System.Collections.Generic;

namespace ProjetoExemplo.Api.ViewModels
{
    public class ClienteViewModel
    {
        public string Nome { get; set; }
        public EnderecoViewModel Endereco { get; set; }
        public List<TelefoneViewModel> Telefones { get; set; }
        public DateTime Cadastro { get; set; }
        public DateTime UltimaAlteracao { get; set; }                                                      
    }
}