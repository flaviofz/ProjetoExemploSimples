using System;

namespace ProjetoExemplo.Api.ViewModels.Commands
{
    public class AdicionarClienteViewModel
    {
        public string Nome { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Ddd { get; set; }
        public string Numero { get; set; }
        public bool Ativo { get; set; }
        public int TipoTelefone { get; set; }
        public DateTime Cadastro { get; set; }
        public DateTime UltimaAlteracao { get; set; }     
    }
}