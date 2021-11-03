using ProjetoExemplo.Business.Models.Enums;

namespace ProjetoExemplo.Api.ViewModels
{
    public class TelefoneViewModel
    {
        public string Ddd { get; set; }
        public string Numero { get; set; }
        public bool Ativo { get; set; }
        public ETipoTelefone TipoTelefone { get; set; }
    }
}